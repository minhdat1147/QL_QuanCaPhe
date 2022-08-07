using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAL_KH:DBConnect
    {
        public DataTable getLoaiSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM khachhang", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable Timkiem(string makh)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM khachhang where makh='" + makh + "'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool them(POJO.DTO_KH ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO khachhang VALUES ('{0}', N'{1}',N'{2}','{3}')", ncc.Makh, ncc.Tenkh, ncc.Diachi, ncc.Sdt);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
        public bool xoa(string makh)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("delete khachhang where makh='{0}'", makh);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
        public bool sua(POJO.DTO_KH ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("update khachhang set tenkh=N'{1}', diachi=N'{2}', sdt='{3}' where makh='{0}'", ncc.Makh, ncc.Tenkh, ncc.Diachi, ncc.Sdt);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
    }
}
