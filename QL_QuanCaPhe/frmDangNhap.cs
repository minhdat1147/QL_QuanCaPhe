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
    public partial class frmDangNhap : Form
    {
        BUS.BUS_NV NV = new BUS.BUS_NV();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "QL01" && textBox2.Text == "123456")
            {
                Program.ten = textBox1.Text;
                MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                frmMain fn = new frmMain();
                this.Hide();
                fn.Show();
            }
            else if (textBox1.Text == "NV01" && textBox2.Text == "123456")
            {
                Program.ten = textBox1.Text;
                Program.TK = "NV";
                MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                frmMain fn = new frmMain();
                this.Hide();
                fn.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại tài khoản hoặc mật khẩu", "Thông Báo");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
