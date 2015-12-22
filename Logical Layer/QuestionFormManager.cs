using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SE2015.Application_Layer;

namespace SE2015.Logical_Layer
{
    class QuestionFormManager
    {


        private List<Question> questions;
        private int questionIndex = 0;
        private GroupBox groupBoxQuestions;

        private Button btnNextQuestion;
        private Label lblQuestionText;
        private List<RadioButton> choices;
        private int courseIndex;

        public QuestionFormManager(GroupBox groupBoxQuestions, Button btnNextQuestion, Label lblQuestionText, List<RadioButton> choices, int courseIndex)
        {

            this.groupBoxQuestions = groupBoxQuestions;

            this.btnNextQuestion = btnNextQuestion;
            this.lblQuestionText = lblQuestionText;
            this.choices = choices;
            this.courseIndex = courseIndex;
            questions = Game.Instance().Subjects[0].Tests[0].QuestionList;
        }

        internal bool ContinueTest()
        {
            if ((questionIndex) == questions.Count)
            {
                if (DialogResult.OK == MessageBox.Show("Testi bitirdiniz.", "Testi bitirdiniz.", MessageBoxButtons.OK))
                {
                    StudentTestValidation.Instance().StudentTookTest = true;

                    return true;
                }
            }
            lblQuestionText.Text = questions[questionIndex].Text;
            for (int i = 0; i < choices.Count; i++)
            {
                choices[i].Text = questions[questionIndex].Answers[i];
            }
            return false;

        }

        internal void CheckResult()
        {

            bool checkedQuestion = false;
            int checkedAnswer = -1;
            for (int i = 0; i < choices.Count; i++)
            {
                if (choices[i].Checked)
                {
                    checkedQuestion = true;
                    checkedAnswer = i;
                }
            }


            if (checkedQuestion)
            {

                if (checkedAnswer == questions[questionIndex].RightAnswer)
                {
                    MessageBox.Show("Soruya doğru cevap verdiniz");

                }
                else
                {
                    MessageBox.Show("Soruya yanlış cevap verdiniz.");
                }
                questionIndex++;
            }
            else
            {

                if (DialogResult.OK == MessageBox.Show("Soruya boş cevap verdiniz. Sonraki soruya geçmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.OKCancel))
                {
                    questionIndex++;
                }
            }
        }
    }
}
