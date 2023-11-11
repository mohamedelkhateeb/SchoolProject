using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.AppMetaData
{
    public class Routes
    {
        public const string root = "API/";
        public const string version = "V1/";
        public const string Rule = root + version;

        public static class StudentRoutes
        {
            public const string prefix = Rule + "Student/";
            public const string GetAllStudents = prefix + "GetAllStudents";
            public const string GetStudentById = prefix  + "{id}";
        }
    }
}
