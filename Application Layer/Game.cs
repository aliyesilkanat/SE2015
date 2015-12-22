using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace SE2015.Application_Layer
{
    class Game
    {
        private static Game instance;
        private List<Subject> subjects;

        internal List<Subject> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }
        public static Game Instance()
        {
            if (instance == null)
            {
                instance = new Game();
            }
            return instance;

        }
        private Game() { subjects = new List<Subject>(); }


        internal void LoadJson(string jsonFile)
        {
            //Load subjects
            foreach (var subjectIterator in JObject.Parse(jsonFile)["courses"].ToList())
            {

                Subject subject = new Subject();
                subject.SubjectTitle = subjectIterator["name"].ToString();

                //Load tests
                foreach (var testIterator in subjectIterator["tests"].ToList())
                {
                    Test test = new Test();
                    test.Difficuilty = testIterator["difficuilty"].ToString();

                    //Load questions
                    foreach (var questionIterator in testIterator["questions"].ToList())
                    {
                        Question question =new Question();
                        question.Text=questionIterator["text"].ToString();

                        //Load answers
                        foreach (var answersIterator in questionIterator["answers"].ToList())
                        {
                            question.Answers.Add(answersIterator.ToString());

                        }
                        question.RightAnswer = Convert.ToInt32(questionIterator["rightAnswer"].ToString());
                        question.ImagePath = questionIterator["imagePath"].ToString();
                        test.QuestionList.Add(question);
                    }

                    subject.Tests.Add(test);

                }

                subjects.Add(subject);
            }






        }
    }
}
