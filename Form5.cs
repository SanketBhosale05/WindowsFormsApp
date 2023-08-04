using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void create_Folder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-AUG";
                if(Directory.Exists(path))
                {
                    MessageBox.Show("folder is already created");
                }
                else
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-AUG\Doc.1";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("file is already created");
                }
                else
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.dac";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fileStream);
                bw.Write(Convert.ToInt32(txtpid.Text));
                bw.Write(txtpname.Text);
                bw.Write(Convert.ToDouble(txtpprice.Text));
                bw.Close();
                fileStream.Close();
                MessageBox.Show("done");

            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try

            {
                string path = @"D:\DP4-2-Aug\product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fileStream);
                txtpid.Text = br.ReadInt32().ToString();
                txtpname.Text = br.ReadString();
               txtpprice.Text = br.ReadDouble().ToString();
                br.Close();
                fileStream.Close();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
