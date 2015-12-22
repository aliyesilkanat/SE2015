using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE2015.Application_Layer
{
    class Test
    {
        private String difficuilty;

        public String Difficuilty
        {
            get { return difficuilty; }
            set { difficuilty = value; }
        }
        private List<Question> questionList;

        internal List<Question> QuestionList
        {
            get { return questionList; }
            set { questionList = value; }
        }
        public Test()
        {
            questionList = new List<Question>();
        }
    }
}
