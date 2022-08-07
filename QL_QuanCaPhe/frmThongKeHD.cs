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
    public partial class frmThongKeHD : Form
    {
        BUS.BUS_HD hdd = new BUS.BUS_HD();
        public frmThongKeHD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain a = new frmMain();
            this.Hide();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = hdd.thongke(dateTimePicker1.Text);
            int tien = dgv1.Rows.Count - 1;
            int tongtien = 0;
            int sl = 0;
            for (int i = 0; i < tien; i++)
            {
                
                    tongtien += int.Parse(dgv1.Rows[i].Cells["TONGTIEN"].Value.ToString());
                    sl = dgv1.Rows.Count - 1;
                

            }
            label1.Text = "Số lượng: " + sl.ToString();
            label2.Text = "Tổng doanh thu: " + tongtien.ToString() + " VNĐ";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
