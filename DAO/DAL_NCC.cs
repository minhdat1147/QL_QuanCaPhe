using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAL_NCC:DBConnect
    {
        public DataTable getLoaiSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM nhacungcap", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable Timkiem(string mancc)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM nhacungcap where mancc='" + mancc + "'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool them(POJO.DTO_NCC ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO nhacungcap VALUES ('{0}', N'{1}',N'{2}','{3}')", ncc.Mancc,ncc.Tenncc,ncc.Diachi,ncc.Sdt);
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
        public bool xoa(string mancc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("delete nhacungcap where mancc='{0}'", mancc);
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
        public bool sua(POJO.DTO_NCC ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("update nhacungcap set tenncc=N'{1}', diachi=N'{2}', sdt='{3}' where mancc='{0}'", ncc.Mancc, ncc.Tenncc, ncc.Diachi, ncc.Sdt);
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
