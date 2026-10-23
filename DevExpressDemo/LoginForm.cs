using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressDemo
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        DashboardForm dashboardForm = new DashboardForm();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPass.Text;

            if(username== "Shad" && password == "asdasd")
            {
                MessageBox.Show("Success");
                this.Hide();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Didn't Work");
            }

            MessageBox.Show("UserName: "+username+"   Password"+password);
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
