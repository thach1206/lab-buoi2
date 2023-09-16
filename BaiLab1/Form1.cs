using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float nb1 = float.Parse(txtSo1.Text);
                float nb2 = float.Parse(txtSo2.Text);
                float rs = nb1 - nb2;
                txtRs.Text =  (nb1 + " - " + nb2 +" = " +rs).ToString();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                float nb1 = float.Parse(txtSo1.Text);
                float nb2 = float.Parse(txtSo2.Text);
                float rs = nb1 + nb2;
                 txtRs.Text = (nb1 + " + " + nb2 + " = " + rs).ToString();

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float nb1 = float.Parse(txtSo1.Text);
                float nb2 = float.Parse(txtSo2.Text);
                float rs = nb1 * nb2;
                txtRs.Text = (nb1 + " * " + nb2 + " = " + rs).ToString();

            }
            catch (Exception )
            {

                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float nb1 = float.Parse(txtSo1.Text);
                float nb2 = float.Parse(txtSo2.Text);
                float rs = nb1 / nb2;
                txtRs.Text = (nb1 + " / " + nb2 + " = " + rs).ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
