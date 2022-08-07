using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POJO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAL_DOUONG:DBConnect
    {
        public DataTable getLoaiSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM douong", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable Timkiem(string maloai)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM douong where maloai='" + maloai + "'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable Timkiem1(string madu)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM douong where madu like '%" + madu + "%'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool them(POJO.DTO_DOUONG du)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO douong VALUES ('{0}', N'{1}',N'{2}',{3},'{4}')", du.Madu, du.Tendu,du.Dvt,du.Dongia,du.Maloai);
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
        public bool sua(POJO.DTO_DOUONG du)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("update douong set tendu=N'{1}', dvt=N'{2}', dongia={3}, maloai='{4}' where madu='{0}'", du.Madu, du.Tendu, du.Dvt, du.Dongia, du.Maloai);
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
        public bool xoa(string du)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("delete douong where madu='{0}'", du);
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
