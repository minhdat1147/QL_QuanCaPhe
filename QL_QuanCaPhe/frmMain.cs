using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCaPhe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDoUong a = new frmDoUong();
            this.Hide();
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmNhaCungCap a = new frmNhaCungCap();
            this.Hide();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNhanVien a = new frmNhanVien();
            this.Hide();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKhachHang a = new frmKhachHang();
            this.Hide();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHoaDon a = new frmHoaDon();
            this.Hide();
            a.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmPhieuNhap a = new frmPhieuNhap();
            this.Hide();
            a.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmThongKeHD a = new frmThongKeHD();
            this.Hide();
            a.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chào : " + Program.ten;
            if (Program.TK == "NV")
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                frmDangNhap dn = new frmDangNhap();
                this.Hide();
                dn.ShowDialog();
            }
        }
    }
}
