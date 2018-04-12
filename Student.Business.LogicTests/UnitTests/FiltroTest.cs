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
using Student.Business.Logic;

namespace Student.Business.LogicTests
{
    [TestClass()]
    public class FiltroTest
    {
        private readonly MockFactory _factory;
        private readonly Mock<SingletonTxt> Singleton;
        public FiltroTest()
        {
            _factory = new MockFactory();
            Singleton = _factory.CreateMock<SingletonTxt>();
        }

        [TestCleanup]
        public void End()
        {
            _factory.ClearExpectations();
      
        }
        [DataRow(1,"54654564f","Dani","Madrigal",27,"14/11/1990","09/04/2018",Campo.Nombre,"Dani")]
        [DataRow(2, "645465465g", "Pepe", "Rodriguez", 34, "07/10/1983", "09/04/2018",Campo.Edad,"34")]
        [DataRow(3, "54654564f", "Luis", "Botillo", 40, "16/08/1985", "09/04/2018",Campo.ID,"3")]
        [TestMethod]
        public void UnitSelectTest(int id, string dni, string nombre, string apellidos, int edad, string fechaNacimiento, string fechaRegistro ,Campo campo ,string value)
        {
            Alumno alumnoIngresado = new Alumno(Guid.NewGuid(),id,dni,nombre,apellidos,edad,fechaNacimiento,fechaRegistro);
            List<Alumno> ListaTest = new List<Alumno> { alumnoIngresado};
            //MethodWith devuelve algo en el metodo, Method no devuelve nada
            Singleton.Expects
                .One
                .Method(s => s.GetList())
                .WillReturn(ListaTest);

            Filtro fl = new Filtro(Singleton.MockObject);
            List<Alumno> resultado = fl.Select(campo,value);
            Assert.IsTrue(resultado.Contains(alumnoIngresado));

        }
    }
}
