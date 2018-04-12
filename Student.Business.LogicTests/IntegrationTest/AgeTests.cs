using Microsoft.VisualStudio.TestTools.UnitTesting;
using Student.Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Student.Common.Logic.Log;

namespace Student.Business.Logic.Tests
{
    [TestClass()]
    public class AgeTests
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [DataRow("14/11/1990","05/04/2018",27)]
        [DataRow("09/04/1989", "05/04/2018", 28)]
        [TestMethod]
        public void IntegrationAreAgeTest(string DateBorn,string DateRegistry ,int result)
        {
            Log.Debug("Iniciamos metodo test de edad");
            Assert.AreEqual(result,Age.AreAge(Convert.ToDateTime(DateBorn),Convert.ToDateTime(DateRegistry)));
            Log.Debug($"Edad calculada es: {result}");
        }
    }
}