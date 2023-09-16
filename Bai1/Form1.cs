using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            float nb1 = float.Parse(lblNumber1.Text);
            float nb2 = float.Parse(lblNumber2.Text);
            float rs = nb1 + nb2;
            txtRs.Text = rs.ToString();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            float nb1 = float.Parse(lblNumber1.Text);
            float nb2 = float.Parse(lblNumber2.Text);
            float rs = nb1 + nb2;
            txtRs.Text = rs.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            float nb1 = float.Parse(lblNumber1.Text);
            float nb2 = float.Parse(lblNumber2.Text);
            float rs = nb1 - nb2;
            lblRs.Text = rs.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float nb1 = float.Parse(lblNumber1.Text);
            float nb2 = float.Parse(lblNumber2.Text);
            float rs = nb1 / nb2;
            lblRs.Text = rs.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            float nb1 = float.Parse(lblNumber1.Text);
            float nb2 = float.Parse(lblNumber2.Text);
            float rs = nb1 * nb2;
            lblRs.Text = rs.ToString();
        }

        
    }
}
