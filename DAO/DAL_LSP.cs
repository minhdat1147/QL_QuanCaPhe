using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using POJO;
namespace DAO
{
    public class DAL_LSP:DBConnect
    {
        public DataTable getLoaiSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM loaidouong", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool them(POJO.DTO_LSP lsp)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO loaidouong VALUES ('{0}', N'{1}')", lsp.Maloai, lsp.Tenloai);
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
        public bool sua(POJO.DTO_LSP lsp)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("update loaidouong set tenloai=N'{1}' where maloai='{0}'", lsp.Maloai, lsp.Tenloai);
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
        public bool xoa(string maloai)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("delete loaidouong where maloai='{0}'", maloai);
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
        public DataTable Timkiem(string maloai)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM loaidouong where maloai='" + maloai + "'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
    }
}
