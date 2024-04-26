namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkbox(object sender, EventArgs e)
        {
            passwordbox.PasswordChar = showpasscheckbox.Checked ? '\0' : '*';
           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Here you can add your authentication logic
            // For now, let's just move to the next form (Form3) when login is clicked
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // Hide the current form
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to Form2 when the link is clicked
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // Hide the current form
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void exitclick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
