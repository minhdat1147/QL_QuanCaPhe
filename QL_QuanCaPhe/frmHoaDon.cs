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
    public partial class frmHoaDon : Form
    {
        
        DBConnect1 Conn = new DBConnect1();
        BUS.BUS_HD hdd = new BUS.BUS_HD();
        
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            Program.mahd = int.Parse(txtMaCTHD.Text);
            frmXuatHD a = new frmXuatHD();
            this.Hide();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                
            string strSQL = "insert into hoadon values('"+Program.ten+"',null,getdate(),0)";
            Conn.updateDatabase(strSQL);
            hoadon();
            loadDL();
        }
        public void hoadon()
        {
            
            string strSQL = "select mahd from hoadon";
            SqlDataReader rdr = Conn.getDataReader(strSQL);
                while (rdr.Read())
                {
                    txtMaCTHD.Text = (rdr["mahd"].ToString());

                }

            rdr.Close();

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_QUANCAPHEDataSet.DOUONG' table. You can move, or remove it, as needed.
            this.dOUONGTableAdapter.Fill(this.qL_QUANCAPHEDataSet.DOUONG);
            txtGia.Enabled = false;
            txtTT.Enabled = false;
            cboTen.Text = "Vui lòng chọn";
            txtMaCTHD.Enabled = false;
        }

        private void cboTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGia.Text = cboTen.SelectedValue.ToString();
            numericUpDown1.Value = 1;
            int sl = Int32.Parse(numericUpDown1.Value.ToString());
            int gia = int.Parse(txtGia.Text);
            int tt = sl * gia;
            txtTT.Text = tt.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int sl = Int32.Parse(numericUpDown1.Value.ToString());
            int gia = int.Parse(txtGia.Text);
            int tt = sl * gia;
            txtTT.Text = tt.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCTHD.Text != "" && cboTen.Text != "" && numericUpDown1.Text != "" && txtGia.Text != "" && txtTT.Text != "")
            {
                int hd=int.Parse(txtMaCTHD.Text);
                int sl=int.Parse(numericUpDown1.Text);
                int dg=int.Parse(txtGia.Text);
                int tt=int.Parse(txtTT.Text);
                POJO.DTO_CTHD sp = new POJO.DTO_CTHD(hd, cboTen.Text, sl, dg, tt);
                if (hdd.them(sp))
                {
                    MessageBox.Show("Thêm thành công");
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
        public void loadDL()
        {
            dgvHD.DataSource = hdd.timkiem1(int.Parse(txtMaCTHD.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain a = new frmMain();
            this.Hide();
            a.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int hd = int.Parse(txtMaCTHD.Text);
            int sl = int.Parse(numericUpDown1.Text);
            int dg = int.Parse(txtGia.Text);
            int tt = int.Parse(txtTT.Text);
            POJO.DTO_CTHD sp = new POJO.DTO_CTHD(hd, cboTen.Text, sl, dg, tt);
            if (hdd.xoa1(sp))
            {
                MessageBox.Show("Xóa thành công");
                loadDL();
            }
            else
            {
                MessageBox.Show("Xóa ko thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int hd = int.Parse(txtMaCTHD.Text);
            int sl = int.Parse(numericUpDown1.Text);
            int dg = int.Parse(txtGia.Text);
            int tt = int.Parse(txtTT.Text);
            POJO.DTO_CTHD sp = new POJO.DTO_CTHD(hd, cboTen.Text, sl, dg, tt);
            if (hdd.sua1(sp))
            {
                MessageBox.Show("Sửa thành công");
                loadDL();
            }
            else
            {
                MessageBox.Show("Sửa ko thành công");
            }
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dgvHD.Rows[e.RowIndex];
            cboTen.Text = li.Cells[0].Value.ToString().Trim();
            numericUpDown1.Text = li.Cells[1].Value.ToString().Trim();
            txtGia.Text = li.Cells[2].Value.ToString().Trim();
            txtTT.Text = li.Cells[3].Value.ToString().Trim();
         
        }
      
    }
}
