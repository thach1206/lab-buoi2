using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBanVe
{

    public partial class Form1 : Form

    {
        int thanhTien = 0;
        List<Button> listbtn = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.White;
                    btn.Name = (i * 5 + j * 1).ToString();
                    btn.Size = new Size(50, 40);
                    btn.Text = (i * 5 + j + 1).ToString();
                    btn.TabIndex = 2;
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += new EventHandler(this.ChoseSeat_Click);

                    btn.Location = new Point(80 + j * 60, 80 + i * 40);
                    this.Controls.Add(btn);

                }
            }
        }

        private void ChoseSeat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White) {
                btn.BackColor = Color.Blue;
                listbtn.Add(btn);
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                listbtn.Remove(btn);
            
            }
            else if (btn.BackColor == Color.Yellow)
                MessageBox.Show("Ghe da ban");

        }
       
        private void btnChon_Click(object sender, EventArgs e)
        {

          


            try
            {
                foreach (Button btn in listbtn)
                {

                    int a = int.Parse(btn.Text);
                    if (a <= 5)
                    {
                        btn.BackColor = Color.Yellow;
                        thanhTien += 30000;
                    }
                    if (5 < a && a <= 10)
                    {
                        btn.BackColor = Color.Yellow;
                        thanhTien += 40000;
                    }
                    if (10 < a && a <= 15)
                    {
                        btn.BackColor = Color.Yellow;
                        thanhTien += 50000;
                    }
                    if (15 < a && a <= 20)
                    {
                        btn.BackColor = Color.Yellow;
                        thanhTien += 80000;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            txtThanhTien.Text = thanhTien.ToString();
            thanhTien = 0;
            listbtn = new List<Button>();
        }

       
            
        


        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            foreach(Button btn in listbtn)
            {
                
                    btn.BackColor= Color.White;
                   
                    txtThanhTien.Text = "";
               
            }
            listbtn = new List<Button> { };
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
