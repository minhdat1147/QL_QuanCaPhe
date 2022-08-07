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
    public partial class frmKhachHang : Form
    {
        BUS.BUS_KH du = new BUS.BUS_KH();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain a = new frmMain();
            this.Hide();
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.makh = txtMaKH.Text;
            Program.tenkh = txtTen.Text;
            Program.gtinh = txtDiachi.Text;
            Program.sdt = txtSDT.Text;
            frmThongKe a = new frmThongKe();
            this.Hide();
            a.ShowDialog();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadDL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtTen.Text != "" && txtDiachi.Text != "" && txtSDT.Text != "")
            {
                POJO.DTO_KH sp = new POJO.DTO_KH(txtMaKH.Text, txtTen.Text, txtDiachi.Text, txtSDT.Text);
                if (du.them(sp))
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtTen.Text != "" && txtDiachi.Text != "" && txtSDT.Text != "")
            {
                POJO.DTO_KH sp = new POJO.DTO_KH(txtMaKH.Text, txtTen.Text, txtDiachi.Text, txtSDT.Text);
                if (du.xoa(txtMaKH.Text))
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtTen.Text != "" && txtDiachi.Text != "" && txtSDT.Text != "")
            {
                POJO.DTO_KH sp = new POJO.DTO_KH(txtMaKH.Text, txtTen.Text, txtDiachi.Text, txtSDT.Text);
                if (du.sua(sp))
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
            dataGridView1.DataSource = du.getLoaiSanPham();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];
            txtMaKH.Text = li.Cells[0].Value.ToString().Trim();
            txtTen.Text = li.Cells[1].Value.ToString().Trim();
            txtDiachi.Text = li.Cells[2].Value.ToString().Trim();
            txtSDT.Text = li.Cells[3].Value.ToString().Trim();
            
        }
        public void xoatrang()
        {
            txtMaKH.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
        }
    }
}
