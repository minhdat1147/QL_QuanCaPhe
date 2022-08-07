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
    public partial class frmThanhToan1 : Form
    {
        BUS.BUS_PN hdd = new BUS.BUS_PN();
        public frmThanhToan1()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            frmXuatPN a = new frmXuatPN();
            this.Hide();
            a.ShowDialog();
        }

        private void frmThanhToan1_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = hdd.timkiem1(Program.mapn);
        }
    }
}
