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
    public partial class frmXuatPN : Form
    {
        DBConnect1 Conn = new DBConnect1();
        BUS.BUS_PN hdd = new BUS.BUS_PN();
        public frmXuatPN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThanhToan1 a = new frmThanhToan1();
            this.Hide();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pn = int.Parse(txtMaHD.Text);
            int tt = int.Parse(txtTongTien.Text);
            POJO.DTO_PN sp = new POJO.DTO_PN(pn, cboMaKh.Text, tt);
            if (hdd.sua(sp))
            {
                MessageBox.Show("Thanh toán thành công", "Thông Báo");
                frmMain a = new frmMain();
                this.Hide();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thanh toán không thành công");
            }  
        }

        private void frmXuatPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_QUANCAPHEDataSet4.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.qL_QUANCAPHEDataSet4.NHACUNGCAP);

            txtMaHD.Text = Program.mapn.ToString() ;
            phieunhap();
            txtMaHD.Enabled = false;
            txtTongTien.Enabled = false;
            txtTen.Enabled = false;
            cboMaKh.Text = "";
        }
        public void phieunhap()
        {

            string strSQL = "select sum(thanhtien) as thanhtien from CHITIETPN where mapn=" + Program.mapn;
            SqlDataReader rdr = Conn.getDataReader(strSQL);
            while (rdr.Read())
            {
                txtTongTien.Text = (rdr["thanhtien"].ToString());

            }

            rdr.Close();

        }

        private void cboMaKh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTen.Text = cboMaKh.SelectedValue.ToString();
        }
    }
}
