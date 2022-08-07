using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DAO;
using POJO;
using BUS;
namespace QL_QuanCaPhe
{
    public partial class frmThanhToan : Form
    {
        BUS.BUS_HD hdd = new BUS.BUS_HD();
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            frmXuatHD a = new frmXuatHD();
            this.Hide();
            a.ShowDialog();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = hdd.timkiem1(Program.mahd);
        }
    }
}
