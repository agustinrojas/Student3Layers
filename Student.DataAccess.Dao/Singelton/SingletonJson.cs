using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Log;
using Student.Common.Logic.Models;
using Student.Common.Logic.Resources;

namespace Student.DataAccess.Dao
{
    public sealed class SingletonJson 
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static SingletonJson instance = null;
        private static readonly object padlock = new object();
        private List<Alumno> students { get; set; }

        public SingletonJson()
        {
            students = new List<Alumno>();
            Load();
        }
        public void Load()
        {
            Log.Debug(LogText.Object);
            StudentDaoJson Js = new StudentDaoJson();
            students = Js.GetAll();
        }
        public List<Alumno> GetList()
        {
            Log.Debug(LogText.Object);
            return students;
        }

        public static SingletonJson Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonJson();
                        }
                    }
                }
                return instance;
            }
        }

       
    }
}
