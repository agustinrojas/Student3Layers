using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Models;
using Student.DataAccess.Dao;

namespace Student.Business.Logic
{
    public interface IStudentBL
    {
        Alumno Add(Alumno student,TypeFormat typeFormat);
        IStudentDao ChangeFormat(TypeFormat typeformat);
        List<Alumno> GetSelect(TypeFormat type , string value,Campo campo);
        List<Alumno> GetAll(TypeFormat typeFormat);
        void LoadDates();
        
    }
}
