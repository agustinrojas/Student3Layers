using Student.Common.Logic.FileUtils;
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
    public sealed class SingletonTxt 
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static SingletonTxt instance = null;
        private static readonly object padlock = new object();
        private List<Alumno> students { get; set; }

        public SingletonTxt()
        {
            students = new List<Alumno>();
            Load();

        }
        public void Load()
        {
            Log.Debug(LogText.Object);
            StudentDaoTxt Js = new StudentDaoTxt();
            students = Js.GetAll();
        }
        public List<Alumno> GetList()
        {
            Log.Debug(LogText.Object);
            return students;
        }

        public static SingletonTxt Instance
        {
            get
            {
                Log.Debug("Comporvamos el que SingletonTxt no este instanciado");
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonTxt();
                        }
                    }
                }
                return instance;
            }
        }

    }
}
