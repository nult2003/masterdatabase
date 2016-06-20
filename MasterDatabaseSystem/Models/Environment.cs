using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDatabaseSystem.Models
{
    public class ProjectEnvironment
    {
        private static ProjectEnvironment instance;
        private static String _rootPath;

        private ProjectEnvironment() { }

        public static ProjectEnvironment Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProjectEnvironment();
                }
                return instance;
            }
        }

        public static string rootPath
        {
            set
            {
                _rootPath = value;
            }
            get
            {
                return _rootPath;
            }
        }
    }
}
