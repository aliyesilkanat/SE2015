using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SE2015.Logical_Layer;

namespace SE2015.UI_Layer.Student
{
    public partial class frmTest : Form
    {
        private int courseIndex;


        public frmTest(int courseIndex)
        {

            InitializeComponent();
            this.courseIndex = courseIndex;
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBoxQuestions.Visible = true;

            QuestionFormManager formManager = new QuestionFormManager();
            List<RadioButton> choices = new List<RadioButton>();
            choices.Add(radioChoice1);
            choices.Add(radioChoice2);
            choices.Add(radioChoice3);
            choices.Add(radioChoice4);
            formManager.controlTest(groupBoxQuestions, groupBoxResult, btnNextQuestion, lblQuestionText, choices,courseIndex);
        }
    }
}
