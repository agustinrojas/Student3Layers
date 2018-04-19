using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic.Log;
using Student.Common.Logic.Models;
using System.Data.SqlClient;
using Student.Common.Logic.Resources;
using System.Data;
using Student.DataAccess.Dao.StudentDao;

namespace Student.DataAccess.Dao
{
    public class StudentDaoSP : IStudentDaoSQL

    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public List<Alumno> Students { get; set; }
        public Alumno Student { get; set; }
        private SqlConnection _conn { get; set; }
        private SqlCommand _cmd { get; set; }
        private readonly string connectionString;

        public StudentDaoSP()
        {
            _conn = null;
            connectionString = Environment.GetEnvironmentVariable("Database", EnvironmentVariableTarget.User);
        }

        public Alumno Add(Alumno student)
        {
            student.ConvertDate();
            
            Log.Debug($"Añadimos los datos {student.ToString()}");
            try
            {
                using (_conn = new SqlConnection(connectionString))
                {
                    using (_cmd = new SqlCommand())
                    {
                        _conn.Open();
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.StoredProcedure;
                        _cmd.Parameters.AddWithValue("@UUID", student.Guid.ToString());
                        _cmd.Parameters.AddWithValue("@Nombre", student.Nombre);
                        _cmd.Parameters.AddWithValue("@Apellido", student.Apellidos);
                        _cmd.Parameters.AddWithValue("@Dni", student.Dni);
                        _cmd.Parameters.AddWithValue("@DateRegistry", student.DateRegistryString);
                        _cmd.Parameters.AddWithValue("@DateBorn", student.DateBornString);
                        _cmd.Parameters.AddWithValue("@Edad", student.Edad);
                        _cmd.ExecuteNonQuery();
                        _cmd.Parameters.Clear();
                        _cmd.CommandText = "SELECT @@IDENTITY";

                        // Obtenga la última identificación insertada. 
                        student.Id = Convert.ToInt32(_cmd.ExecuteScalar());
                        Log.Debug($"Recuperamos el id {student.Id}");
                        return student;
                    }

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);

                throw;
            }
            finally
            {
                _conn = null;
            }
        }


        public List<Alumno> GetAll()
        {
            Students = new List<Alumno>();

            string sql = Query.SelectAll;

            Log.Debug($"Añadimos los datos a lista Students");
            try
            {
                using (_conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand _cmd = new SqlCommand(sql, _conn))
                    {
                        _conn.Open();
                        using (SqlDataReader srd = _cmd.ExecuteReader())
                        {
                            if (srd.HasRows)
                            {
                                while (srd.Read())
                                {
                                    Student = new Alumno();
                                    Student.Guid = Guid.Parse(srd.GetString(0));
                                    Student.Id = srd.GetInt32(1);
                                    Student.Nombre = srd.GetString(2);
                                    Student.Apellidos = srd.GetString(3);
                                    Student.Dni = srd.GetString(4);
                                    Student.DateRegistry = Convert.ToDateTime(srd.GetString(5));
                                    Student.DateBorn = Convert.ToDateTime(srd.GetString(6));
                                    Student.Edad = srd.GetInt32(7);
                                    Log.Debug($"Añadimos {Student.ToString()} en memoria");
                                    Students.Add(Student);
                                }
                                return Students;
                            }
                            else
                            {
                                return Students;
                            }

                        }


                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);

                throw;
            }

        }

        public Alumno Delete(Alumno student)
        {
            throw new NotImplementedException();
        }

        public Alumno Update(Alumno student)
        {
            throw new NotImplementedException();
        }
    }
}
