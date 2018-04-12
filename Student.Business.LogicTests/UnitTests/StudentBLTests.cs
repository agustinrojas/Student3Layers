using Microsoft.VisualStudio.TestTools.UnitTesting;
using Student.Business.Logic;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Student.Common.Logic.Log;
using NMock;
using Student.DataAccess.Dao;

namespace Student.Business.Logic.Tests
{
    [TestClass()]
    public class StudentBLTests
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private  MockFactory _factory;
        private   Mock<IStudentDao> StudentDaoMock;
        private  Mock<IStudentBL> StudentBLMock;


       
        [TestInitialize]
        public void Init()
        {
            _factory = new MockFactory();
            StudentDaoMock = _factory.CreateMock<IStudentDao>();
            StudentBLMock = _factory.CreateMock<IStudentBL>();
        }
        [TestCleanup]
        public void Exit()
        {
            _factory.ClearExpectations();
        }
        [DataRow(TypeFormat.Txt)]
        [TestMethod]
        public void UnitBlAddTestTxt(TypeFormat typeFormat)
        {
            Alumno student = new Alumno(Guid.NewGuid(), 1, "45687654h", "Daniel", "Madrigal", 28, "24/06/1990", "05/09/2017");
            //MetohdWith cuando el metodo espera parámetros
            StudentBLMock.Expects
                .One
                .MethodWith(StudentBLMockInstance=> StudentBLMockInstance.Add(student ,typeFormat))
                .WillReturn(student);

            Assert.AreEqual(student,StudentBLMock.MockObject.Add(student,typeFormat));
        }

        [DataRow(TypeFormat.Xml)]
        [TestMethod]
        public void UnitBlAddTestXml(TypeFormat typeFormat)
        {
            Alumno student = new Alumno(Guid.NewGuid(), 1, "45687654h", "Daniel", "Madrigal", 28, "24/06/1990", "05/09/2017");
            //MetohdWith cuando el metodo espera parámetros
            StudentBLMock.Expects
                .One
                .MethodWith(StudentBLMockInstance => StudentBLMockInstance.Add(student, typeFormat))
                .WillReturn(student);

            Assert.AreEqual(student, StudentBLMock.MockObject.Add(student, typeFormat));
        }
        [DataRow(TypeFormat.Json)]
        [TestMethod]
        public void UnitBlAddTestJson(TypeFormat typeFormat)
        {
            Alumno student = new Alumno(Guid.NewGuid(), 1, "45687654h", "Daniel", "Madrigal", 28, "24/06/1990", "05/09/2017");
            //MetohdWith cuando el metodo espera parámetros
            StudentBLMock.Expects
                .One
                .MethodWith(StudentBLMockInstance => StudentBLMockInstance.Add(student, typeFormat))
                .WillReturn(student);

            Assert.AreEqual(student, StudentBLMock.MockObject.Add(student, typeFormat));
        }

        [TestMethod()]
        public void UnitGetAllTest()
        {
            List<Alumno> Students = new List<Alumno>
            {
                new Alumno(Guid.NewGuid(),1, "54654564f", "Dani", "Madrigal", 27, "14/11/1990", "09/04/2018"),
                new Alumno(Guid.NewGuid(),2, "645465465g", "Pepe", "Rodriguez", 34, "07/10/1983", "09/04/2018"),
                new Alumno(Guid.NewGuid(),3, "54654564f", "Luis", "Botillo", 40, "16/08/1985", "09/04/2018")
            };

            StudentDaoMock.Expects
                .One
                .Method(StudentDaoMockInstance=> StudentDaoMockInstance.GetAll())
                .WillReturn(Students);
            StudentBLMock.Expects
                .One
                .MethodWith(StudentBLMockInstance => StudentBLMockInstance.GetAll(TypeFormat.Txt))
                .WillReturn(Students);
           
            Assert.AreEqual(Students, StudentBLMock.MockObject.GetAll(TypeFormat.Txt));
        }
    }
}