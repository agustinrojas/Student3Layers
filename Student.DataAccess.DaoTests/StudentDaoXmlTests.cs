﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Student.Common.Logic.FileUtils;
using Student.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Student.Common.Logic.Models;

namespace Student.DataAccess.Dao.Tests
{
    [TestClass()]
    public class StudentDaoXmlTests
    {
        private readonly string Path = FileUtils.Path("xml");
        private readonly StudentDaoXml studentDaoXml = new StudentDaoXml();
        [TestInitialize]
        public void Init()
        {
            if (FileUtils.FileExists(Path)) File.Delete(Path);
        }
        [TestCleanup]
        public void End()
        {
            File.Delete(Path);
        }
        public static IEnumerable<object[]> StudentData()
        {
            yield return new object[] { new Alumno(Guid.NewGuid(), 1, "45687654h", "Daniel", "Madrigal", 28, "24/06/1990","05/09/2017") };
            yield return new object[] { new Alumno(Guid.NewGuid(), 2, "46546546h", "Rebeca", "Barreira", 28, "24/06/1989", "07/11/2016") };
        }
        [DataTestMethod]
        [DynamicData(nameof(StudentData),DynamicDataSourceType.Method)]
        public void XmlAddTest(Alumno student)
        {
            var result = studentDaoXml.Add(student);
            Assert.IsTrue(student.Equals(result));
        }

       
    }
}