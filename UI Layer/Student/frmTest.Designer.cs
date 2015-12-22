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
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxQuestions = new System.Windows.Forms.GroupBox();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.radioChoice1 = new System.Windows.Forms.RadioButton();
            this.radioChoice2 = new System.Windows.Forms.RadioButton();
            this.radioChoice3 = new System.Windows.Forms.RadioButton();
            this.radioChoice4 = new System.Windows.Forms.RadioButton();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
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
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(419, 121);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(75, 23);
            this.btnStartTest.TabIndex = 2;
            this.btnStartTest.Text = "BAŞLA";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
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
            // groupBoxQuestions
            // 
            this.groupBoxQuestions.Controls.Add(this.lblTimer);
            this.groupBoxQuestions.Controls.Add(this.btnNextQuestion);
            this.groupBoxQuestions.Controls.Add(this.radioChoice4);
            this.groupBoxQuestions.Controls.Add(this.radioChoice3);
            this.groupBoxQuestions.Controls.Add(this.radioChoice2);
            this.groupBoxQuestions.Controls.Add(this.radioChoice1);
            this.groupBoxQuestions.Controls.Add(this.lblQuestionText);
            this.groupBoxQuestions.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxQuestions.Location = new System.Drawing.Point(0, 159);
            this.groupBoxQuestions.Name = "groupBoxQuestions";
            this.groupBoxQuestions.Size = new System.Drawing.Size(943, 312);
            this.groupBoxQuestions.TabIndex = 1;
            this.groupBoxQuestions.TabStop = false;
            this.groupBoxQuestions.Text = "Test";
            this.groupBoxQuestions.Visible = false;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestionText.Location = new System.Drawing.Point(31, 32);
            this.lblQuestionText.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(61, 24);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "Soruu";
            // 
            // radioChoice1
            // 
            this.radioChoice1.AutoSize = true;
            this.radioChoice1.Location = new System.Drawing.Point(27, 176);
            this.radioChoice1.Name = "radioChoice1";
            this.radioChoice1.Size = new System.Drawing.Size(85, 17);
            this.radioChoice1.TabIndex = 1;
            this.radioChoice1.TabStop = true;
            this.radioChoice1.Text = "radioButton1";
            this.radioChoice1.UseVisualStyleBackColor = true;
            // 
            // radioChoice2
            // 
            this.radioChoice2.AutoSize = true;
            this.radioChoice2.Location = new System.Drawing.Point(130, 176);
            this.radioChoice2.Name = "radioChoice2";
            this.radioChoice2.Size = new System.Drawing.Size(85, 17);
            this.radioChoice2.TabIndex = 1;
            this.radioChoice2.TabStop = true;
            this.radioChoice2.Text = "radioButton1";
            this.radioChoice2.UseVisualStyleBackColor = true;
            // 
            // radioChoice3
            // 
            this.radioChoice3.AutoSize = true;
            this.radioChoice3.Location = new System.Drawing.Point(231, 176);
            this.radioChoice3.Name = "radioChoice3";
            this.radioChoice3.Size = new System.Drawing.Size(85, 17);
            this.radioChoice3.TabIndex = 1;
            this.radioChoice3.TabStop = true;
            this.radioChoice3.Text = "radioButton1";
            this.radioChoice3.UseVisualStyleBackColor = true;
            // 
            // radioChoice4
            // 
            this.radioChoice4.AutoSize = true;
            this.radioChoice4.Location = new System.Drawing.Point(331, 176);
            this.radioChoice4.Name = "radioChoice4";
            this.radioChoice4.Size = new System.Drawing.Size(85, 17);
            this.radioChoice4.TabIndex = 1;
            this.radioChoice4.TabStop = true;
            this.radioChoice4.Text = "radioButton1";
            this.radioChoice4.UseVisualStyleBackColor = true;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(436, 176);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(92, 23);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "İşaretle ve Geç";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTimer.Location = new System.Drawing.Point(27, 217);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(51, 20);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "label3";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 471);
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
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.RadioButton radioChoice4;
        private System.Windows.Forms.RadioButton radioChoice3;
        private System.Windows.Forms.RadioButton radioChoice2;
        private System.Windows.Forms.RadioButton radioChoice1;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblTimer;
    }
}