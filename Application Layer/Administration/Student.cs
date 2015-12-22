using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE2015.Application_Layer.Administration
{
    class Student : Account
    {
        private bool solvedTest=false;

        public bool SolvedTest
        {
            get { return solvedTest; }
            set { solvedTest = value; }
        }
    }
}
