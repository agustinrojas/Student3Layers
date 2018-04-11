using Student.Common.Logic.Log;
using Student.Common.Logic.Models;
using Student.Common.Logic.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccess.Dao
{
    public sealed class SingletonSql
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static SingletonSql instance = null;
        private static readonly object padlock = new object();
        private List<Alumno> students { get; set; }

        private SingletonSql()
        {
            students = new List<Alumno>();
            Load();
        }
        public void Load()
        {
            Log.Debug(LogText.Object);
            StudentDaoSql Js = new StudentDaoSql();
            students = Js.GetAll();
        }
        public List<Alumno> GetList()
        {
            Log.Debug(LogText.Object);
            return students;
        }

        public static SingletonSql Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonSql();
                        }
                    }
                }
                return instance;
            }
        }

      
    }
}
