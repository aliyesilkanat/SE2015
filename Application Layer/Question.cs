using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE2015.Application_Layer
{
    class Question
    {
        private String text;
        private String imagePath;

        public String ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        public String Text
        {
            get { return text; }
            set { text = value; }
        }
        private List<String> answers;

        public List<String> Answers
        {
            get { return answers; }
            set { answers = value; }
        }
        private int rightAnswer;

        public int RightAnswer
        {
            get { return rightAnswer; }
            set { rightAnswer = value; }
        }
        public Question()
        {
            answers = new List<string>();
        }
    }
}
