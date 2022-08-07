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
    public class DAL_NV:DBConnect
    {
        public DataTable getLoaiSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM nhanvien", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }  
        public bool them(POJO.DTO_NV du)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO nhanvien VALUES ('{0}', N'{1}','{2}',N'{3}',N'{4}','{5}','{6}',N'{7}')", du.Manv, du.Tennv, du.Ngaysinh, du.Gtinh, du.Diachi, du.Sdt, du.Cmnd, du.Chucvu);
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
        public bool sua(POJO.DTO_NV du)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("update nhanvien set tennv=N'{1}', ngaysinh='{2}', gtinh=N'{3}', diachi=N'{4}', sdt='{5}',cmnd='{6}', chucvu=N'{7}' where manv='{0}'", du.Manv, du.Tennv, du.Ngaysinh, du.Gtinh, du.Diachi, du.Sdt, du.Cmnd, du.Chucvu);
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
                string SQL = string.Format("delete nhanvien where manv='{0}'", du);
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
        public bool DangNhap(string manv,string sdt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM nhanvien where manv='" + manv + "' and sdt='" + sdt + "'", _conn);
                DataTable dtThanhvien = new DataTable();
                da.Fill(dtThanhvien);       
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
