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
    public partial class frmDoUong : Form
    {
        BUS.BUS_DOUONG du = new BUS.BUS_DOUONG();
        public frmDoUong()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLoaiDoUong a = new frmLoaiDoUong();
            this.Hide();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain a = new frmMain();
            this.Hide();
            a.ShowDialog();
        }

        private void frmDoUong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abc.LOAIDOUONG' table. You can move, or remove it, as needed.
            this.lOAIDOUONGTableAdapter1.Fill(this.abc.LOAIDOUONG);
            // TODO: This line of code loads data into the 'qL_QUANCAPHEDataSet1.LOAIDOUONG' table. You can move, or remove it, as needed.
            this.lOAIDOUONGTableAdapter.Fill(this.qL_QUANCAPHEDataSet1.LOAIDOUONG);    
            loadDL();
            cboLoai.Text = "Tất cả";
        }
        public void loadDL()
        {
            dataGridView1.DataSource = du.getLoaiSanPham();
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = du.timkiem(cboLoai.SelectedValue.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];
            txtMS.Text = li.Cells[0].Value.ToString().Trim();
            txtTen.Text = li.Cells[1].Value.ToString().Trim();
            cboDVT.Text = li.Cells[2].Value.ToString().Trim();
            txtGia.Text = li.Cells[3].Value.ToString().Trim();
            cboMaLoai.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMS.Text != "" && txtTen.Text != ""&&txtGia.Text != "" && cboMaLoai.Text != ""&& cboDVT.Text != "")
            {
                int dongia=int.Parse(txtGia.Text);
                POJO.DTO_DOUONG sp = new POJO.DTO_DOUONG(txtMS.Text,txtTen.Text,cboDVT.Text,dongia,cboMaLoai.SelectedValue.ToString());
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMS.Text != "" && txtTen.Text != "" && txtGia.Text != "" && cboMaLoai.Text != "" && cboDVT.Text != "")
            {
                int dongia = int.Parse(txtGia.Text);
                POJO.DTO_DOUONG sp = new POJO.DTO_DOUONG(txtMS.Text, txtTen.Text, cboDVT.Text, dongia, cboMaLoai.SelectedValue.ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMS.Text != "" && txtTen.Text != "" && txtGia.Text != "" && cboMaLoai.Text != "" && cboDVT.Text != "")
            {
                int dongia = int.Parse(txtGia.Text);
                POJO.DTO_DOUONG sp = new POJO.DTO_DOUONG(txtMS.Text, txtTen.Text, cboDVT.Text, dongia, cboMaLoai.SelectedValue.ToString());
                if (du.xoa(txtMS.Text))
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

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = du.timkiem1(txtTim.Text);
        }

        private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void xoatrang()
        {
            txtMS.Text = "";
            txtGia.Text = "";
            txtTen.Text = "";
            cboMaLoai.Text = "";
            cboDVT.Text = "";

        }
    }
}
