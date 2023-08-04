using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "HR", "Sales", "Admin", "Manager", "Developmet", "Testing" };
            cmbdepartlist.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(textbasicsalary.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.20;
            double da = bs * 0.10;
            double pf = bs * 0.12;

            double gross = (bs + hra + da + ta) - pf;
            textHRa.Text = hra.ToString();    
            textDA.Text = da.ToString();
            textTA.Text = ta.ToString();
            textPF.Text = pf.ToString();
            textGROS.Text = gross.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show($" id={textEMPID.Text}  \n name= {textEmpName.Text} \n DepName ={cmbdepartlist} \n basic salary = { textbasicsalary.Text}" );


        }
    }
}
