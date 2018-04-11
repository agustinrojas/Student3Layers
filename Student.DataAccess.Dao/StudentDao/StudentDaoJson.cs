using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic.Models;
using System.IO;
using Student.Common.Logic.FileUtils;
using Newtonsoft.Json;
using log4net;
using Student.Common.Logic.Log;
using Student.Common.Logic.Resources;


namespace Student.DataAccess.Dao
{
    public class StudentDaoJson : IStudentDao
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly string Path = FileUtils.Path(Format.Json);
        private List<Alumno> students = new List<Alumno>();
        public Alumno Add(Alumno student)
        {
            if (FileUtils.FileExists(Path))
            {
                Log.Debug("El fichero Registro.json existe");
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        try
                        {
                            string lista = sr.ReadToEnd();  
                            students = JsonConvert.DeserializeObject<List<Alumno>>(lista);
                            Log.Debug("Cargamos la lista de los alumnos");
                        }
                        catch (FileNotFoundException e)
                        {
                            Log.Error("No se a podidio leer el archivo"+e);
                            throw ;
                        }
                        finally
                        {
                            sr.Close();
                            fs = null;
                        }
                    }
                    fs = new FileStream(Path,FileMode.Create,FileAccess.Write);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        try
                        {
                            student.ConvertDate();
                            students.Add(student);
                            string lista = JsonConvert.SerializeObject(students);
                            sw.WriteLine(lista);
                            Log.Debug($"El alumno {student.ToString()} a sido insertado");

                        }
                        catch (FileNotFoundException)
                        {
                            Log.Error("No se ha podido añadir el alumno");
                            throw;
                        }
                        finally
                        {
                            sw.Close();
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    Log.Error("No se ha encontrado el archivo");
                    throw;
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
                return Deserialize();
               
            }
            else
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Path, FileMode.Create, FileAccess.Write);
                    Log.Debug("El archivo Registro.json ha sido creado");
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        try
                        {
                            sw.WriteLine($"[{student.ToJson()}]");
                            Log.Debug($"Alumno {student.ToString()} añadido");
                        }
                        catch (FileNotFoundException)
                        {
                            Log.Error("No se ha podido escribir en el archivo");
                            throw;
                        }
                        finally
                        {
                            sw.Close();
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    Log.Error("No se ha podido crear el archivo Registro.json");
                    throw;
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
                return Deserialize();

            }
        }

        public Alumno Deserialize()
        {
            Alumno alumnoDS;
            FileStream fs = null;
            try
            {
                fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fs))
                {
                    try
                    {
                        string lista = sr.ReadToEnd();
                        students = JsonConvert.DeserializeObject<List<Alumno>>(lista);
                        alumnoDS = students.Last();
                        Log.Debug($"Alumno {alumnoDS.ToString()} devluelto");
                        return alumnoDS;
                       
                    }
                    catch (FileNotFoundException)
                    {
                        Log.Error("No se ha insertar el alumno");
                        throw;
                    }
                    finally
                    {
                        sr.Close();
                    }
                }
            }
            catch (FileLoadException)
            {
                Log.Error("No se ha podidio crear el archivo");
                throw;
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        public List<Alumno> GetAll()
        {
            Log.Debug("Cargamos la lista json");
            FileStream fl = null;
            try
            {
                fl = new FileStream(Path,FileMode.Open,FileAccess.Read);
                using (StreamReader sr = new StreamReader(fl))
                {
                    try
                    {
                        string registro = sr.ReadToEnd();
                        students = JsonConvert.DeserializeObject<List<Alumno>>(registro);
                        Log.Debug("Cargamos la lista de los alumnos");
                    }
                    catch (FileLoadException)
                    {
                        Log.Error("No se ha podido leer el fichero");
                        throw;
                    }
                    finally
                    {
                       sr.Close();
                    }
                
                }
                return students;
            }
            catch (FileNotFoundException)
            {
                Log.Error("No se puede acceder al archivo");
                throw;
            }
            finally
            {
                if (fl != null) fl.Close();
            }
            
        }
    }
}
