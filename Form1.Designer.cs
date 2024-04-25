namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bindingSource1 = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            exitclick = new Label();
            label2 = new Label();
            username = new Label();
            password = new Label();
            usernamebox = new TextBox();
            passwordbox = new TextBox();
            Loginbtn = new Button();
            showpasscheckbox = new CheckBox();
            registerlink = new LinkLabel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.DarkBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.99501252F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.00499F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.34897F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.65103F));
            tableLayoutPanel1.Size = new Size(368, 533);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(10, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 305);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AliceBlue;
            label6.Location = new Point(10, 311);
            label6.Name = "label6";
            label6.Size = new Size(168, 18);
            label6.TabIndex = 9;
            label6.Text = "One stop student center";
            label6.Click += label6_Click;
            // 
            // exitclick
            // 
            exitclick.AutoSize = true;
            exitclick.Location = new Point(738, 8);
            exitclick.Name = "exitclick";
            exitclick.Size = new Size(16, 18);
            exitclick.TabIndex = 0;
            exitclick.Text = "x";
            exitclick.Click += exitclick_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(421, 55);
            label2.Name = "label2";
            label2.Size = new Size(112, 18);
            label2.TabIndex = 1;
            label2.Text = "Login Account";
            label2.Click += label2_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(421, 127);
            username.Name = "username";
            username.Size = new Size(80, 18);
            username.TabIndex = 2;
            username.Text = "Username:";
            username.Click += label3_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(421, 227);
            password.Name = "password";
            password.Size = new Size(74, 18);
            password.TabIndex = 3;
            password.Text = "Password:";
            password.Click += label4_Click;
            // 
            // usernamebox
            // 
            usernamebox.Location = new Point(421, 172);
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(184, 26);
            usernamebox.TabIndex = 0;
            // 
            // passwordbox
            // 
            passwordbox.Location = new Point(421, 278);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(184, 26);
            passwordbox.TabIndex = 4;
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.DarkTurquoise;
            Loginbtn.Location = new Point(421, 349);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(94, 29);
            Loginbtn.TabIndex = 5;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // showpasscheckbox
            // 
            showpasscheckbox.AutoSize = true;
            showpasscheckbox.Location = new Point(582, 310);
            showpasscheckbox.Name = "showpasscheckbox";
            showpasscheckbox.Size = new Size(129, 22);
            showpasscheckbox.TabIndex = 6;
            showpasscheckbox.Text = "show password";
            showpasscheckbox.UseVisualStyleBackColor = true;
            showpasscheckbox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // registerlink
            // 
            registerlink.AutoSize = true;
            registerlink.Location = new Point(488, 447);
            registerlink.Name = "registerlink";
            registerlink.Size = new Size(156, 18);
            registerlink.TabIndex = 7;
            registerlink.TabStop = true;
            registerlink.Text = "Get yourself registered";
            registerlink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 447);
            label5.Name = "label5";
            label5.Size = new Size(99, 18);
            label5.TabIndex = 8;
            label5.Text = "Not sgined in?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 533);
            Controls.Add(label5);
            Controls.Add(registerlink);
            Controls.Add(showpasscheckbox);
            Controls.Add(Loginbtn);
            Controls.Add(passwordbox);
            Controls.Add(usernamebox);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(exitclick);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label exitclick;
        private Label label2;
        private Label username;
        private Label password;
        private TextBox usernamebox;
        private TextBox passwordbox;
        private Button Loginbtn;
        private CheckBox showpasscheckbox;
        private LinkLabel registerlink;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
