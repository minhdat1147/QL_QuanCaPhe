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
    public partial class frmLoaiDoUong : Form
    {
        BUS.BUS_LSP buslsp = new BUS.BUS_LSP();
        public frmLoaiDoUong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDoUong a = new frmDoUong();
            this.Hide();
            a.ShowDialog();
        }

        private void frmLoaiDoUong_Load(object sender, EventArgs e)
        {
            loadDL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text != "" && txtTenLoai.Text != "")
            {
                POJO.DTO_LSP sp = new POJO.DTO_LSP(txtMaLoai.Text, txtTenLoai.Text);
                if (buslsp.them(sp))
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

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text != "")
            {
                if (buslsp.xoa(txtMaLoai.Text))
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
            if (txtMaLoai.Text != "" && txtTenLoai.Text != "")
            {
                POJO.DTO_LSP sp = new POJO.DTO_LSP(txtMaLoai.Text, txtTenLoai.Text);
                if (buslsp.sua(sp))
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
        public void loadDL()
        {
            dgvDSLoai.DataSource = buslsp.getLoaiSanPham();
        }

        private void dgvDSLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dgvDSLoai.Rows[e.RowIndex];
            txtMaLoai.Text = li.Cells[0].Value.ToString().Trim();
            txtTenLoai.Text = li.Cells[1].Value.ToString().Trim();
        }
        public void xoatrang()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }
    }
}
