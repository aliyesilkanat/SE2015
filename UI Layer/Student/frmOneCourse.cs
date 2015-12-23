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
    public partial class frmOneCourse : Form
    {
        private Panel panelFormContainer;
        private Form selectedForm;
        private int courseIndex;
        private ToolStripMenuItem menu;


        public frmOneCourse(Panel panelFormContainer, Form selectedForm, int courseIndex, ToolStripMenuItem menu)
        {
            InitializeComponent();
            this.panelFormContainer = panelFormContainer;
            this.selectedForm = selectedForm;
            this.courseIndex = courseIndex;
            this.menu = menu;
            if (Login.tipi != "Öğretmen")
            {
                this.linkLabel4.Visible = false;
                this.linkLabel3.Visible = false;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectedForm.Dispose();
            selectedForm = new frmExperimentContainer();
            selectedForm.TopLevel = false;
            panelFormContainer.Controls.Add(selectedForm);
            selectedForm.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (!StudentTestValidation.Instance().StudentTookTest)
            {

                selectedForm.Dispose();
                selectedForm = new frmTest(courseIndex, selectedForm, panelFormContainer, menu);
                selectedForm.TopLevel = false;
                panelFormContainer.Controls.Add(selectedForm);
                selectedForm.Show();
            }
            else
            {
                MessageBox.Show("Bu testi daha önce çözdünüz.");
            }
        }


    }
}
