using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbKhoa.SelectedIndex = 0;
            txtNu.Text = 0.ToString();
            txtNam.Text = 0.ToString();
        }


        private int GetSelectedRow(string studentID)
        {
           
            for (int i = 0; i< dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent!=null &&  dgvStudent.Rows[i].Cells[0].Value?.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtID.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = rdoNu.Checked?"Nu":"Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtAvr.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cmbKhoa.Text;
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtAvr.Text == "")
                    throw new Exception("Vui long nhap day du thong tin");
                int slRow = GetSelectedRow(txtID.Text);
                if(slRow == -1)
                {
                    slRow = dgvStudent.Rows.Add();
                    InsertUpdate(slRow);
                    MessageBox.Show("Them du lieu thanh cong!", "Thong bao", MessageBoxButtons.OK);
                    txtNu.Text = slNu().ToString();
                    txtNam.Text = slNam().ToString();
                    reset();
                }
                else
                {
                    InsertUpdate(slRow);
                    MessageBox.Show("Cap nhat du lieu thanh cong!", "Thong bao", MessageBoxButtons.OK);
                    txtNu.Text = slNu().ToString();
                    txtNam.Text = slNam().ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }
        private void reset()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAvr.Text = "";
            rdoNu.Checked = true;
            cmbKhoa.SelectedIndex = 0;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int slRows = GetSelectedRow(txtID.Text);
                if(slRows == -1)
                {
                    throw new Exception("Khong tim thay MSSV can xoa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Ban co muon xoa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(slRows);
                        MessageBox.Show("Xoa thanh cong");
                        txtNu.Text = slNu().ToString();
                        txtNam.Text = slNam().ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int slNu()
        {
            int tongSVNu = 0;
            for(int i = 0; i< dgvStudent.Rows.Count; i++) {
                if (dgvStudent != null && dgvStudent.Rows[i].Cells["GioiTinh"].Value?.ToString() == "Nu")
                {
                    tongSVNu++;
                }
            }
            return tongSVNu;
        }
        private int slNam()
        {
            int tongSVNam = 0;
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent != null && dgvStudent.Rows[i].Cells["GioiTinh"].Value?.ToString() == "Nam")
                {
                    tongSVNam++;
                }
            }
            return tongSVNam;
        }
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvStudent.CurrentCell.Selected = true;
                    txtID.Text = dgvStudent.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtAvr.Text = dgvStudent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

                    if (dgvStudent.Rows[e.RowIndex].Cells[3].FormattedValue.ToString() == "Nu")
                    {
                        rdoNu.Checked = true;
                    }
                    else { rdoNam.Checked = true; }
                    cmbKhoa.Text = dgvStudent.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
