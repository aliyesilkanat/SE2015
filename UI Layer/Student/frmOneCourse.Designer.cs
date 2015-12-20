namespace SE2015.UI_Layer.Student
{
    partial class frmOneCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCourseExperiments = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBoxCourseTests = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBoxCourseExperiments.SuspendLayout();
            this.groupBoxCourseTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCourseExperiments
            // 
            this.groupBoxCourseExperiments.Controls.Add(this.linkLabel1);
            this.groupBoxCourseExperiments.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCourseExperiments.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCourseExperiments.Name = "groupBoxCourseExperiments";
            this.groupBoxCourseExperiments.Size = new System.Drawing.Size(710, 100);
            this.groupBoxCourseExperiments.TabIndex = 0;
            this.groupBoxCourseExperiments.TabStop = false;
            this.groupBoxCourseExperiments.Text = "Deneyler";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(25, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 24);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kaldıraç";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBoxCourseTests
            // 
            this.groupBoxCourseTests.Controls.Add(this.linkLabel2);
            this.groupBoxCourseTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCourseTests.Location = new System.Drawing.Point(0, 100);
            this.groupBoxCourseTests.Name = "groupBoxCourseTests";
            this.groupBoxCourseTests.Size = new System.Drawing.Size(710, 100);
            this.groupBoxCourseTests.TabIndex = 1;
            this.groupBoxCourseTests.TabStop = false;
            this.groupBoxCourseTests.Text = "Testler";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.Location = new System.Drawing.Point(29, 20);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(198, 24);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Basit Makineler - Kolay";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmOneCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 262);
            this.Controls.Add(this.groupBoxCourseTests);
            this.Controls.Add(this.groupBoxCourseExperiments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOneCourse";
            this.ShowInTaskbar = false;
            this.Text = "frmOneCourse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxCourseExperiments.ResumeLayout(false);
            this.groupBoxCourseExperiments.PerformLayout();
            this.groupBoxCourseTests.ResumeLayout(false);
            this.groupBoxCourseTests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCourseExperiments;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBoxCourseTests;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}