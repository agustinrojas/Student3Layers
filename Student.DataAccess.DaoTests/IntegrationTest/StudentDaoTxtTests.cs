using Microsoft.VisualStudio.TestTools.UnitTesting;
using Student.Common.Logic.FileUtils;
using Student.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Student.Common.Logic.Models;
using log4net;
using Student.Common.Logic.Log;

namespace Student.DataAccess.Dao.Tests
{
    [TestClass()]
    public class StudentDaoTxtTests
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly string Path = FileUtils.Path("txt");
        private readonly StudentDaoTxt studentDaoTxt = new StudentDaoTxt();
        [TestInitialize]
        public void Init()
        {
            Log.Debug("Limpiamos de ficheros existentes");
            if (FileUtils.FileExists(Path)) File.Delete(Path);
        }
        [TestCleanup]
        public void End()
        {
            Log.Debug("Elimina todos los ficheros");
            File.Delete(Path);
        }
        public static IEnumerable<object[]> StudentData()
        {
            yield return new object[] { new Alumno(Guid.NewGuid(), 1, "45687654h", "Daniel", "Madrigal", 28, "24/06/1990", "05/09/2017") };
            yield return new object[] { new Alumno(Guid.NewGuid(), 2, "46546546h", "Rebeca", "Barreira", 28, "24/06/1989", "07/11/2016") };
        }
        [DataTestMethod]
        [DynamicData(nameof(StudentData), DynamicDataSourceType.Method)]
        public void IntegrationTxtAddTest(Alumno student)
        {
            Log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + " Agrega alumno");
            var result = studentDaoTxt.Add(student);
            Log.Debug($"EL alumno devuelto {result.ToString()}");
            Assert.IsTrue(student.Equals(result));
        }

    }
}