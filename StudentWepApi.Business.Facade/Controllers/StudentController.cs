using Student.Business.Logic;
using Student.Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace StudentWepApi.Business.Facade.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentBL _istudentBL = null;

        public StudentController(IStudentBL istudentBL)
        {
            _istudentBL = istudentBL;
        }

        /// <summary>
        /// Muestras un usuario con Get.
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public IHttpActionResult Get()
        {
            return Ok(_istudentBL.Get());
        }

        /// <summary>
        /// Introduces un usuario y lo guardas en redis.
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost()]
        public IHttpActionResult Set(Alumno student)
        {

            return Ok(_istudentBL.Set(student));
        }
    }
}