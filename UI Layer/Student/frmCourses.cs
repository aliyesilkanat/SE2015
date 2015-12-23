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
    public partial class frmCourses : Form
    {
        private ToolStripMenuItem toolStripMenuItem;
        private Form selectedForm;
        private Panel panelFormContainer;
        public frmCourses(ToolStripMenuItem toolStripMenuItem,ref Form selectedForm, Panel panelFormContainer)
        {
            InitializeComponent();
            this.toolStripMenuItem = toolStripMenuItem;
            this.selectedForm = selectedForm;
            this.panelFormContainer = panelFormContainer;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clickCourse();    
        }
        public void clickCourse() {
            selectedForm.Dispose();
            selectedForm = new frmOneCourse(panelFormContainer, selectedForm, 0, toolStripMenuItem);
            FormStateManager.Instance = selectedForm;
            toolStripMenuItem.Enabled = true;
            selectedForm.TopLevel = false;
            panelFormContainer.Controls.Add(selectedForm);
            selectedForm.Show();
        }
    }
}
