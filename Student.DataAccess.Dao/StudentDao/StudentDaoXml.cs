using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic.Models;
using System.IO;
using Student.Common.Logic.FileUtils;
using System.Xml.Serialization;
using log4net;
using Student.Common.Logic.Log;
using Student.Common.Logic.Resources;

namespace Student.DataAccess.Dao
{
    public class StudentDaoXml : IStudentDao
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly string Path = FileUtils.Path(Format.Xml);
        private List<Alumno> students = new List<Alumno>();
        public Alumno Add(Alumno student)
        {
            XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
            if (FileUtils.FileExists(Path))
            {
                Log.Debug("El fichero Registro.xml existe");
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        try
                        {
                            String xml = sr.ReadToEnd();
                            StringReader stringReader = new StringReader(xml);
                            students = (List<Alumno>)xSeriz.Deserialize(stringReader);
                            student.ConvertDate();
                            students.Add(student);
                            Log.Debug("Cargamos la lista de los alumnos");
                           
                        }
                        catch (FileNotFoundException)
                        {
                            Log.Error("No se ha podido cargar la lista");
                            throw;
                        }
                        finally
                        {
                            sr.Close();
                            fs = null;
                        }
                    }
                    fs = new FileStream(Path, FileMode.Create, FileAccess.Write);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        try
                        {
                            xSeriz.Serialize(sw,students);
                            Log.Debug($"Objeto {student.ToString()} instertado");
                        }
                        catch (FileNotFoundException)
                        {
                            Log.Error("No se ha podido insertar el Alumno");
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
                    Log.Error("No se ha podido cargar el archivo Registro.xml");
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
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        try
                        {
                            student.ConvertDate();
                            students.Add(student);
                            xSeriz.Serialize(sw,students);
                            Log.Debug($"Objeto {student.ToString()} instertado");
                        }
                        catch (FileNotFoundException)
                        {
                            Log.Error("No se ha podido insertar el Alumno");
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
                    Log.Error("No se ha podido cargar el archivo Registro.xml");
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
            XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
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
                        String xml = sr.ReadToEnd();
                        StringReader stringReader = new StringReader(xml);
                        students = (List<Alumno>)xSeriz.Deserialize(stringReader);
                        alumnoDS = students.Last();
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
                Log.Error("No se ha podido cargar el archivo Registro.xml");
                throw;
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        public List<Alumno> Filtro(Campo campo, string value)
        {
            return students;
        }

        public List<Alumno> GetAll()
        {
            XmlSerializer xSeriz = new XmlSerializer(typeof(List<Alumno>));
            Log.Debug("El fichero Registro.xml existe");
            FileStream fs = null;
            try
            {
                fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fs))
                {
                    try
                    {
                        Alumno student = new Alumno();
                        String xml = sr.ReadToEnd();
                        StringReader stringReader = new StringReader(xml);
                        students = (List<Alumno>)xSeriz.Deserialize(stringReader);
                        students.Add(student);
                        Log.Debug("Cargamos la lista de los alumnos");
                        return students;
                    }
                    catch (FileLoadException)
                    {
                        Log.Error("No se ha podido cargar la lista");
                        throw;
                    }
                    finally
                    {
                        sr.Close();
                        fs = null;
                    }
                }
            }
            catch(FileNotFoundException)
            {
                Log.Error("No se ha encontrado el archivo");
                throw;
            }
            finally
            {
                if(fs!=null)fs.Close();
            }
        }
    }
}
