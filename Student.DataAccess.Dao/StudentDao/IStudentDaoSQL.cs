using Student.Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccess.Dao.StudentDao
{
    public interface IStudentDaoSQL
    {
        Alumno Add(Alumno student);
        List<Alumno> GetAll();
        Alumno Select(Alumno student);
        Alumno Delete(Alumno student);
        Alumno Update(Alumno student);
    }
}
