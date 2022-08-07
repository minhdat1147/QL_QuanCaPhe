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
    public partial class frmXuatHD : Form
    {
        DBConnect1 Conn = new DBConnect1();
        BUS.BUS_HD hdd = new BUS.BUS_HD();
        public frmXuatHD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThanhToan a = new frmThanhToan();
            this.Hide();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                int hd = int.Parse(txtMaHD.Text);
       
    
                int tt = int.Parse(txtTongTien.Text);
                POJO.DTO_HD sp = new POJO.DTO_HD(hd,cboMaKh.Text,tt);
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

        private void frmXuatHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_QUANCAPHEDataSet2.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qL_QUANCAPHEDataSet2.KHACHHANG);

            txtMaHD.Text = Program.mahd.ToString();
            hoadon();
            txtMaHD.Enabled = false;
            txtTongTien.Enabled = false;
            txtTen.Enabled = false;
            cboMaKh.Text = "";
        }
        public void hoadon()
        {

            string strSQL = "select sum(thanhtien) as thanhtien from CHITIETHD where mahd="+Program.mahd;
            SqlDataReader rdr = Conn.getDataReader(strSQL);
            while (rdr.Read())
            {
                txtTongTien.Text = (rdr["thanhtien"].ToString()) ;

            }

            rdr.Close();

        }

        private void cboMaKh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTen.Text = cboMaKh.SelectedValue.ToString();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
