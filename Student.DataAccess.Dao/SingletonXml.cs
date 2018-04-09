﻿using Student.Common.Logic.Models;
using System;
using System.Collections.Generic;
using log4net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Log;

namespace Student.DataAccess.Dao
{
    public sealed class SingletonXml :ISingleton
    {
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static SingletonXml instance = null;
        private static readonly object padlock = new object();
        private readonly List<Alumno> students;

        public SingletonXml()
        {
            Log.Debug("Cargamos la lista el archiva"); 
            StudentDaoXml Sx = new StudentDaoXml();
            students = Sx.GetAll();
        }
        public List<Alumno> GetList()
        {
            Log.Debug("Devuelve la lista cargada");
            return students;
        }

        public static SingletonXml Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonXml();
                        }
                    }
                }
                return instance;
            }
        }

        
    }
}
