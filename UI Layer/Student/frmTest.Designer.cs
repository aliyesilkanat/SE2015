namespace SE2015.UI_Layer.Student
{
    partial class frmTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.groupBoxQuestions = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnStartTest);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bu testte 15 soru bulunmaktadır. Soruları çözebilmeniz için 15 dakikanız mevcuttu" +
    "r. 15 dakika sonrasında sadece işratlediğiniz sorular dikkatte alınacaktır.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hazır olduğunuzda başla butonuna basınız.";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(419, 121);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(75, 23);
            this.btnStartTest.TabIndex = 2;
            this.btnStartTest.Text = "BAŞLA";
            this.btnStartTest.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuestions
            // 
            this.groupBoxQuestions.Controls.Add(this.label3);
            this.groupBoxQuestions.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxQuestions.Location = new System.Drawing.Point(0, 159);
            this.groupBoxQuestions.Name = "groupBoxQuestions";
            this.groupBoxQuestions.Size = new System.Drawing.Size(919, 274);
            this.groupBoxQuestions.TabIndex = 1;
            this.groupBoxQuestions.TabStop = false;
            this.groupBoxQuestions.Text = "Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gördüğünüz bir soruya bir daha dönme imkanınız bulunmamaktadır. Lütfen dikkat edi" +
    "niz.";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 433);
            this.Controls.Add(this.groupBoxQuestions);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTest";
            this.ShowInTaskbar = false;
            this.Text = "frmTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxQuestions.ResumeLayout(false);
            this.groupBoxQuestions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxQuestions;
        private System.Windows.Forms.Label label3;
    }
}