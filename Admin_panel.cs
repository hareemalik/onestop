using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onestop
{
    public partial class Admin_panel : Form
    {
        public Admin_panel()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.Show();
            this.Hide();
        }

        private void Admin_panel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_login ap = new Admin_login();
            ap.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register_Students rs = new Register_Students();
            rs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register_Faculty rf = new Register_Faculty();
            rf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            issue_feechallan ifc = new issue_feechallan();
            ifc.Show();
            this.Hide();
        }
    }
}
