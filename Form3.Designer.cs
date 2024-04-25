namespace WinFormsApp3
{
    partial class Form3
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            button11 = new Button();
            Admitcardbtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            Feechallanbtn = new Button();
            Transcript = new Button();
            counselling = new Button();
            Homebtn = new Button();
            internshipbtn = new Button();
            button19 = new Button();
            Mentorshipbtn = new Button();
            Eventsbtn = new Button();
            lostfoundbtn = new Button();
            Feedbackbtn = new Button();
            specialbtn = new Button();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(145, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 57);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.Location = new Point(56, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 2;
            label1.Text = "Welcome student";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(Feedbackbtn);
            panel2.Controls.Add(specialbtn);
            panel2.Controls.Add(lostfoundbtn);
            panel2.Controls.Add(Eventsbtn);
            panel2.Controls.Add(Mentorshipbtn);
            panel2.Controls.Add(button19);
            panel2.Controls.Add(internshipbtn);
            panel2.Controls.Add(Homebtn);
            panel2.Controls.Add(counselling);
            panel2.Controls.Add(Transcript);
            panel2.Controls.Add(Feechallanbtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(Admitcardbtn);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 616);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepSkyBlue;
            label2.Location = new Point(12, 28);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "Dashboard";
            // 
            // button11
            // 
            button11.BackColor = Color.CornflowerBlue;
            button11.ForeColor = SystemColors.ControlLightLight;
            button11.Location = new Point(12, 396);
            button11.Name = "button11";
            button11.Size = new Size(177, 33);
            button11.TabIndex = 10;
            button11.Text = "Id issuance";
            button11.UseVisualStyleBackColor = false;
            // 
            // Admitcardbtn
            // 
            Admitcardbtn.BackColor = Color.CornflowerBlue;
            Admitcardbtn.ForeColor = SystemColors.ControlLightLight;
            Admitcardbtn.Location = new Point(12, 435);
            Admitcardbtn.Name = "Admitcardbtn";
            Admitcardbtn.Size = new Size(177, 33);
            Admitcardbtn.TabIndex = 9;
            Admitcardbtn.Text = "Admit card";
            Admitcardbtn.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.PowderBlue;
            dateTimePicker1.CalendarTitleBackColor = Color.Sienna;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.AppWorkspace;
            dateTimePicker1.Location = new Point(177, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(990, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 175);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // Feechallanbtn
            // 
            Feechallanbtn.BackColor = Color.CornflowerBlue;
            Feechallanbtn.ForeColor = SystemColors.ControlLightLight;
            Feechallanbtn.Location = new Point(12, 201);
            Feechallanbtn.Name = "Feechallanbtn";
            Feechallanbtn.Size = new Size(177, 33);
            Feechallanbtn.TabIndex = 11;
            Feechallanbtn.Text = "Fee Challan";
            Feechallanbtn.UseVisualStyleBackColor = false;
            // 
            // Transcript
            // 
            Transcript.BackColor = Color.CornflowerBlue;
            Transcript.ForeColor = SystemColors.ControlLightLight;
            Transcript.Location = new Point(12, 162);
            Transcript.Name = "Transcript";
            Transcript.Size = new Size(177, 33);
            Transcript.TabIndex = 12;
            Transcript.Text = "L]Transcript";
            Transcript.UseVisualStyleBackColor = false;
            // 
            // counselling
            // 
            counselling.BackColor = Color.CornflowerBlue;
            counselling.ForeColor = SystemColors.ControlLightLight;
            counselling.Location = new Point(12, 123);
            counselling.Name = "counselling";
            counselling.Size = new Size(177, 33);
            counselling.TabIndex = 13;
            counselling.Text = "o-<counselling";
            counselling.UseVisualStyleBackColor = false;
            // 
            // Homebtn
            // 
            Homebtn.BackColor = Color.CornflowerBlue;
            Homebtn.ForeColor = SystemColors.ControlLightLight;
            Homebtn.Location = new Point(12, 87);
            Homebtn.Name = "Homebtn";
            Homebtn.Size = new Size(177, 33);
            Homebtn.TabIndex = 14;
            Homebtn.Text = "/\\-\\ Home\n";
            Homebtn.UseVisualStyleBackColor = false;
            // 
            // internshipbtn
            // 
            internshipbtn.BackColor = Color.CornflowerBlue;
            internshipbtn.ForeColor = SystemColors.ControlLightLight;
            internshipbtn.Location = new Point(12, 318);
            internshipbtn.Name = "internshipbtn";
            internshipbtn.Size = new Size(177, 33);
            internshipbtn.TabIndex = 15;
            internshipbtn.Text = "Degree issuance";
            internshipbtn.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = Color.CornflowerBlue;
            button19.ForeColor = SystemColors.ControlLightLight;
            button19.Location = new Point(12, 357);
            button19.Name = "button19";
            button19.Size = new Size(177, 33);
            button19.TabIndex = 16;
            button19.Text = "Internship";
            button19.UseVisualStyleBackColor = false;
            // 
            // Mentorshipbtn
            // 
            Mentorshipbtn.BackColor = Color.CornflowerBlue;
            Mentorshipbtn.ForeColor = SystemColors.ControlLightLight;
            Mentorshipbtn.Location = new Point(12, 240);
            Mentorshipbtn.Name = "Mentorshipbtn";
            Mentorshipbtn.Size = new Size(177, 33);
            Mentorshipbtn.TabIndex = 17;
            Mentorshipbtn.Text = "Mentorship";
            Mentorshipbtn.UseVisualStyleBackColor = false;
            // 
            // Eventsbtn
            // 
            Eventsbtn.BackColor = Color.CornflowerBlue;
            Eventsbtn.ForeColor = SystemColors.ControlLightLight;
            Eventsbtn.Location = new Point(12, 474);
            Eventsbtn.Name = "Eventsbtn";
            Eventsbtn.Size = new Size(177, 33);
            Eventsbtn.TabIndex = 18;
            Eventsbtn.Text = "Events";
            Eventsbtn.UseVisualStyleBackColor = false;
            // 
            // lostfoundbtn
            // 
            lostfoundbtn.BackColor = Color.CornflowerBlue;
            lostfoundbtn.ForeColor = SystemColors.ControlLightLight;
            lostfoundbtn.Location = new Point(12, 279);
            lostfoundbtn.Name = "lostfoundbtn";
            lostfoundbtn.Size = new Size(177, 33);
            lostfoundbtn.TabIndex = 19;
            lostfoundbtn.Text = "Lost and Found";
            lostfoundbtn.UseVisualStyleBackColor = false;
            // 
            // Feedbackbtn
            // 
            Feedbackbtn.BackColor = Color.CornflowerBlue;
            Feedbackbtn.ForeColor = SystemColors.ControlLightLight;
            Feedbackbtn.Location = new Point(12, 552);
            Feedbackbtn.Name = "Feedbackbtn";
            Feedbackbtn.Size = new Size(177, 33);
            Feedbackbtn.TabIndex = 12;
            Feedbackbtn.Text = "Feedback";
            Feedbackbtn.UseVisualStyleBackColor = false;
            // 
            // specialbtn
            // 
            specialbtn.BackColor = Color.CornflowerBlue;
            specialbtn.ForeColor = SystemColors.ControlLightLight;
            specialbtn.Location = new Point(12, 513);
            specialbtn.Name = "specialbtn";
            specialbtn.Size = new Size(177, 33);
            specialbtn.TabIndex = 13;
            specialbtn.Text = "special students";
            specialbtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(251, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 213);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkBlue;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(3, -1);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 5;
            label4.Text = "Academic Calendar";
            label4.Click += label4_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(309, 29);
            panel4.TabIndex = 6;
            panel4.Paint += panel4_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 44);
            label5.Name = "label5";
            label5.Size = new Size(264, 20);
            label5.TabIndex = 5;
            label5.Text = "Registration: 17-Jan-2024-21-Jan-2024";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 74);
            label6.Name = "label6";
            label6.Size = new Size(293, 20);
            label6.TabIndex = 5;
            label6.Text = "Online Feedback16-Feb-2024-27-Feb-2024";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 139);
            label7.Name = "label7";
            label7.Size = new Size(264, 20);
            label7.TabIndex = 5;
            label7.Text = "Online Withdraw request: 05-Feb-2024";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 106);
            label8.Name = "label8";
            label8.Size = new Size(254, 20);
            label8.TabIndex = 6;
            label8.Text = "Classes: 22-Jan-2024 to 10-May-2024";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 169);
            label9.Name = "label9";
            label9.Size = new Size(264, 20);
            label9.TabIndex = 5;
            label9.Text = "Online Retake request: After Mid Exam";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 618);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button11;
        private Button Admitcardbtn;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button lostfoundbtn;
        private Button Eventsbtn;
        private Button Mentorshipbtn;
        private Button button19;
        private Button internshipbtn;
        private Button Homebtn;
        private Button counselling;
        private Button Transcript;
        private Button Feechallanbtn;
        private Button Feedbackbtn;
        private Button specialbtn;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label9;
    }
}