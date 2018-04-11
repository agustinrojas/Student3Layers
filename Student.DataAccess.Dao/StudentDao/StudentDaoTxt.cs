using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Models;
using System.IO;
using log4net;
using Student.Common.Logic.Log;
using Student.Common.Logic.Resources;
using System.Resources;

namespace Student.DataAccess.Dao
{
    public class StudentDaoTxt : IStudentDao
    {
        
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly string Path = FileUtils.Path(Format.Txt);
        public List<Alumno> Students { get ; set; }

        public Alumno Add(Alumno student)
        {
            if (FileUtils.FileExists(Path))
            {
                Log.Debug("El fichero Registro.txt existe");
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Path,FileMode.Append,FileAccess.Write);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        try
                        {
                            sw.WriteLine(student.ToString());
                            Log.Debug($"Alumno {student.ToString()} registrado ");
                        }
                        catch (FileNotFoundException)
                        {
                            Log.Error("No se ha podido insertar el alumno");
                            throw ;
                        }
                        finally
                        {
                            sw.Close();
                        }
                    }
                }
                catch (FileLoadException)
                {
                    Log.Error("No se ha podido cargar el archivo");
                    throw ;
                }
                catch(UnauthorizedAccessException )
                {
                    Log.Error("No se tiene acesso al archivo");
                    throw;
                }
                finally
                {
                    if (fs!=null) fs.Close();
                }
                return Deserialize();
            }
            else
            {
                Log.Debug("El archivo Registro.Txt no existe");
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Path, FileMode.Create, FileAccess.Write);
                    Log.Debug("Archivo REgistro.txt creado.");
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        try
                        {
                            sw.WriteLine(student.ToString());
                            Log.Debug($"Alumno {student.ToString()} insertado");
                        }
                        catch (FileNotFoundException)
                        {
                            Log.Error("No se ha podido insertar el alumo");
                            throw;
                        }
                        finally
                        {
                            sw.Close();
                        }
                    }
                }
                catch (FileLoadException)
                {
                    Log.Error("No se ha podido crear el archivo ");
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
                        Log.Debug("Cargando lista de insertados");
                        string[] props = new string[8];
                        string linea = "";
                        while ((linea = sr.ReadLine()) != null)
                        {
                            props = linea.Split(',');
                        }
                        alumnoDS = new Alumno(Guid.Parse(props[0]), Convert.ToInt32(props[1]), props[2], props[3], props[4], Convert.ToInt32(props[5]), props[6], props[7]);
                        Log.Debug($"Objeto recuperado {alumnoDS.ToString()}");
                        return alumnoDS;
                    }
                    catch (FileNotFoundException)
                    {
                        Log.Debug("No se ha podido cargar la lista");
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
                Log.Error("No se ha podido cargar el archivo Registro.txt");
                throw;
            }
            finally
            {
                if (fs != null) fs.Close();
            } 
        }

        public List<Alumno> GetAll()
        {
            Students = new List<Alumno>();
            FileStream fl = null;
            try
            {
                fl = new FileStream(Path,FileMode.Open,FileAccess.Read);
                using (StreamReader sr = new StreamReader(fl))
                {
                    try
                    {
                        Log.Debug("Cargando lista de insertados");
                        Alumno alumno;
                        string linea = "";
                        while ((linea = sr.ReadLine()) != null)
                        {
                            string[] props = new string[8];
                            props = linea.Split(',');
                            alumno = new Alumno(Guid.Parse(props[0]), Convert.ToInt32(props[1]), props[2], props[3], props[4], Convert.ToInt32(props[5]), props[6], props[7]);
                            Students.Add(alumno);
                        }
                        Log.Debug("Lista cargada");
                        return Students;
                    }
                    catch (FileLoadException)
                    {
                        Log.Error("No se ha podido leer el archivo");
                        throw;
                    }
                    finally
                    {
                        sr.Close();
                    }
                   
                }

            }
            catch (FileNotFoundException)
            {
                Log.Error("Archivo Registro.txt no encontrado");
                throw;
            }
            finally
            {
                if (fl != null) fl.Close();
            }
        }

    

    }
}
