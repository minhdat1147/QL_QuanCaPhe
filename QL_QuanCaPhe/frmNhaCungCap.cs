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
    public partial class frmNhaCungCap : Form
    {
        BUS.BUS_NCC ncc = new BUS.BUS_NCC();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmMain a = new frmMain();
            this.Hide();
            a.ShowDialog();
        }

        private void btnDSPN_Click(object sender, EventArgs e)
        {
            frmThongKePN a = new frmThongKePN();
            this.Hide();
            a.ShowDialog();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            loadDL();

        }
        public void loadDL()
        {
            dataGridView1.DataSource = ncc.getLoaiSanPham();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];
            txtMaNCC.Text = li.Cells[0].Value.ToString().Trim();
            txtTen.Text = li.Cells[1].Value.ToString().Trim();
            txtSDt.Text = li.Cells[2].Value.ToString().Trim();
            txtDiachi.Text = li.Cells[3].Value.ToString().Trim();
            Program.mancc = txtMaNCC.Text;
            Program.tenncc = txtTen.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text != "" && txtTen.Text != "" && txtSDt.Text != "" && txtDiachi.Text != "")
            {
                POJO.DTO_NCC sp = new POJO.DTO_NCC(txtMaNCC.Text, txtTen.Text, txtSDt.Text, txtDiachi.Text);
                if (ncc.them(sp))
                {
                    MessageBox.Show("Thêm thành công");
                    xoatrang();
                    loadDL();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text != "" && txtTen.Text != "" && txtSDt.Text != "" && txtDiachi.Text != "")
            {
                POJO.DTO_NCC sp = new POJO.DTO_NCC(txtMaNCC.Text, txtTen.Text, txtSDt.Text, txtDiachi.Text);
                if (ncc.xoa(txtMaNCC.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    xoatrang();
                    loadDL();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text != "" && txtTen.Text != "" && txtSDt.Text != "" && txtDiachi.Text != "")
            {
                POJO.DTO_NCC sp = new POJO.DTO_NCC(txtMaNCC.Text, txtTen.Text, txtSDt.Text, txtDiachi.Text);
                if (ncc.sua(sp))
                {
                    MessageBox.Show("Sửa thành công");
                    xoatrang();
                    loadDL();
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
        public void xoatrang()
        {
            txtMaNCC.Text = "";
            txtTen.Text = "";
            txtSDt.Text = "";
            txtDiachi.Text = "";

        }
    }
}
