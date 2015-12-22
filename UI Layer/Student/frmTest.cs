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
        private QuestionFormManager formManager;
        List<RadioButton> choices = new List<RadioButton>();
        private Form selectedForm;
        private Panel panelFormContainer;
        private ToolStripMenuItem menu;



        public frmTest(int courseIndex, Form selectedForm, Panel panelFormContainer, ToolStripMenuItem menu)
        {
            InitializeComponent();
            this.courseIndex = courseIndex;

            choices.Add(radioChoice1);
            choices.Add(radioChoice2);
            choices.Add(radioChoice3);
            choices.Add(radioChoice4);

            this.selectedForm = selectedForm;
            this.panelFormContainer = panelFormContainer;
            this.menu = menu;
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBoxQuestions.Visible = true;
            if (TestTimer.Instance().Index != 0)
            {
                TestTimer.Instance().Start(this);
            }

            formManager = new QuestionFormManager(groupBoxQuestions, btnNextQuestion, lblQuestionText, choices, courseIndex);
            formManager.ContinueTest();

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            formManager.CheckResult();
            if (formManager.ContinueTest())
            {

                selectedForm.Dispose();
                selectedForm = new frmCourses(menu, selectedForm, panelFormContainer);
                selectedForm.TopLevel = false;
                panelFormContainer.Controls.Add(selectedForm);
                selectedForm.Show();

            }
        }


        public void TickExternal(int timer)
        {
            if (timer == 0)
            {

                BeginInvoke((MethodInvoker)delegate
                {
                    MessageBox.Show("Süreniz doldu!");
                    selectedForm.Dispose();
                    selectedForm = new frmCourses(menu, selectedForm, panelFormContainer);
                    selectedForm.TopLevel = false;
                    panelFormContainer.Controls.Add(selectedForm);
                    selectedForm.Show();
                });
            }
            else
            {
                DisplayTimer(timer);
            }
        }

        private void DisplayTimer(int timerCounter)
        {
            int totalSeconds = timerCounter;
            int seconds = totalSeconds % 60;
            int minutes = totalSeconds / 60;
            String secondsStr = seconds == 0 ? "00" : seconds + "";
            lblTimer.Text = minutes + ":" + secondsStr;
        }



    }
}
