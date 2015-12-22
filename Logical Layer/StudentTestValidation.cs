using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SE2015.Application_Layer;

namespace SE2015.Logical_Layer
{
    class StudentTestValidation
    {
        private static StudentTestValidation instance;
        public bool StudentTookTest
        {
            get
            {
                return Game.Instance().Student.SolvedTest;
            }
            set { Game.Instance().Student.SolvedTest = value; }
        }
        private StudentTestValidation()
        {

        }
        public static StudentTestValidation Instance()
        {

            if (instance == null)
            {
                instance = new StudentTestValidation();
            }
            return
                instance;
        }
    }
}
