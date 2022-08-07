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
    public partial class frmThongKe : Form
    {
        BUS.BUS_HD busHD = new BUS.BUS_HD();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKhachHang a = new frmKhachHang();
            this.Hide();
            a.ShowDialog();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtGT.Enabled = false;
            txtSDT.Enabled = false;
            txtMaKH.Text = Program.makh;
            txtTenKH.Text = Program.tenkh;
            txtGT.Text = Program.gtinh;
            txtSDT.Text = Program.sdt;
            dataGridView1.DataSource = busHD.timkiem(txtMaKH.Text);
        }
    }
}
