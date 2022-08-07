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
    public partial class frmThongKePN : Form
    {
        BUS.BUS_PN buspn = new BUS.BUS_PN();
        public frmThongKePN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhaCungCap a = new frmNhaCungCap();
            this.Hide();
            a.ShowDialog();
        }

        private void frmThongKePN_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtMaKH.Text = Program.mancc;
            txtTenKH.Text = Program.tenncc;
            dataGridView1.DataSource = buspn.timkiem(txtMaKH.Text);
        }
    }
}
