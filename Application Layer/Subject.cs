using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE2015.Application_Layer
{
    class Subject
    {
        private String subjectTitle;

        public String SubjectTitle
        {
            get { return subjectTitle; }
            set { subjectTitle = value; }
        }
        private List<Test> tests;

        internal List<Test> Tests
        {
            get { return tests; }
            set { tests = value; }
        }
        public Subject()
        {
            tests = new List<Test>();
        }
    }
}
