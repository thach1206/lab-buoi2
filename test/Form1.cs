using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                foreach (CheckBox c in this.Controls)
                {
                    c.Checked = true;
                }
            }
            else
            {
                foreach (CheckBox c in this.Controls) { c.Checked = false; }
            }
        }
    }
}
