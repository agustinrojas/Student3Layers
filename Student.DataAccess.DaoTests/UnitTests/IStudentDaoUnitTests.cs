using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic.Log;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using Student.DataAccess.Dao;

namespace Student.Business.LogicTests.UnitTests
{
    [TestClass()]
    public class IStudentDaoUnitTests
    {
        private MockFactory _factory;
        private Mock<IStudentDao> _IStudentDao;

        [TestInitialize()]
        public void init()
        {
            _factory = new MockFactory();
            _IStudentDao = _factory.CreateMock<IStudentDao>();
        }

        [TestCleanup()]
        public void End()
        {
            _factory.ClearExpectations();
        }
        [DataRow(1, "54654564f", "Dani", "Madrigal", 27, "14/11/1990", "09/04/2018", Campo.Nombre, "Dani")]
        [DataRow(2, "54567678t", "Agus", "Rojas", 24, "02/04/1994", "09/04/2018", Campo.Nombre, "Agus")]
        [DataRow(3, "98765564m", "David", "Garcia", 23, "09/09/1995", "09/04/2018", Campo.Nombre, "David")]
        [TestMethod]
        public void UnitAddTest(int id, string dni, string nombre, string apellidos, int edad, string fechaNacimiento, string fechaRegistro, Campo campo, string value)
        {
            Alumno alumnoIngresado = new Alumno(Guid.NewGuid(), id, dni, nombre, apellidos, edad, fechaNacimiento, fechaRegistro);
            Alumno alumnoDevuelto = alumnoIngresado;

            alumnoDevuelto.Id = 23;

            _IStudentDao.Expects
                .One
                .MethodWith(s => s.Add(alumnoIngresado))
                .WillReturn(alumnoDevuelto);

            Assert.AreEqual(alumnoDevuelto, _IStudentDao.MockObject.Add(alumnoIngresado));
        }

        [DataRow(1, "54654564f", "Dani", "Madrigal", 27, "14/11/1990", "09/04/2018", Campo.Nombre, "Dani")]
        [DataRow(2, "54567678t", "Agus", "Rojas", 24, "02/04/1994", "09/04/2018", Campo.Nombre, "Agus")]
        [DataRow(3, "98765564m", "David", "Garcia", 23, "09/09/1995", "09/04/2018", Campo.Nombre, "David")]
        [TestMethod]
        public void UnitGetAllTest(int id, string dni, string nombre, string apellidos, int edad, string fechaNacimiento, string fechaRegistro, Campo campo, string value)
        {
            Alumno alumnoIngresado = new Alumno(Guid.NewGuid(), id, dni, nombre, apellidos, edad, fechaNacimiento, fechaRegistro);
            List<Alumno> ListaTestGetAll = new List<Alumno> { alumnoIngresado };


            _IStudentDao.Expects
                .One
                .Method(s => s.GetAll())
                .WillReturn(ListaTestGetAll);

            Assert.AreEqual(ListaTestGetAll, _IStudentDao.MockObject.GetAll());
        }

    }


}