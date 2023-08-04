using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "admin" && txtPassword.Text == "admin123")

                MessageBox.Show("Login succefully");

            else
            {
                MessageBox.Show("Invalid Details");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtPassword.Clear();


        }
    }
}
