using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POJO;
using BUS;
namespace QL_QuanCaPhe
{
    public partial class frmNhanVien : Form
    {
        BUS.BUS_NV du = new BUS.BUS_NV();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain a = new frmMain();
            this.Hide();
            a.ShowDialog();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadDL();
        }
        public void loadDL()
        {
            dataGridView1.DataSource = du.getLoaiSanPham();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];
            txtMaNV.Text = li.Cells[0].Value.ToString().Trim();
            txtTenNV.Text = li.Cells[1].Value.ToString().Trim();
            dtNS.Text = li.Cells[2].Value.ToString().Trim();
            cboGT.Text = li.Cells[3].Value.ToString().Trim();
            txtDiaChi.Text = li.Cells[4].Value.ToString().Trim();
            txtSDT.Text = li.Cells[5].Value.ToString().Trim();
            txtCMND.Text = li.Cells[6].Value.ToString().Trim();
            cboCV.Text = li.Cells[7].Value.ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && dtNS.Text != "" && cboGT.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtCMND.Text != "" && cboCV.Text != "")
            {
                POJO.DTO_NV sp = new POJO.DTO_NV(txtMaNV.Text, txtTenNV.Text, dtNS.Text, cboGT.Text, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, cboCV.Text);
                if (du.them(sp))
                {
                    MessageBox.Show("Thêm thành công");
                    loadDL();
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && dtNS.Text != "" && cboGT.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtCMND.Text != "" && cboCV.Text != "")
            {

                POJO.DTO_NV sp = new POJO.DTO_NV(txtMaNV.Text, txtTenNV.Text, dtNS.Text, cboGT.Text, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, cboCV.Text);
                if (du.xoa(txtMaNV.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    loadDL();
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && dtNS.Text != "" && cboGT.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtCMND.Text != "" && cboCV.Text != "")
            {

                POJO.DTO_NV sp = new POJO.DTO_NV(txtMaNV.Text, txtTenNV.Text, dtNS.Text, cboGT.Text, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, cboCV.Text);
                if (du.sua(sp))
                {
                    MessageBox.Show("Sửa thành công");
                    loadDL();
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
        public void XoaTrang()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            cboCV.Text = "";
            cboGT.Text = "";
   
        }

        private void cboGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
