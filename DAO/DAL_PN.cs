using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAL_PN:DBConnect
    {
        public DataTable Timkiem(string mancc)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM phieunhap where mancc='" + mancc + "'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool them(POJO.DTO_CTPN ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO CHITIETPN VALUES ({0}, N'{1}',{2},{3},{4})", ncc.Mapn, ncc.Tensp, ncc.Sl, ncc.Dongia, ncc.Thanhtien);
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
        public DataTable Timkiem1(int mahd)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TENSP,SOLUONG,DONGIA,THANHTIEN FROM CHITIETPN where mapn=" + mahd + "", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool sua(POJO.DTO_PN ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("update phieunhap set mancc='{1}' , tongtien={2} where mapn={0}", ncc.Mapn, ncc.Mancc, ncc.Tongtien);
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
        public bool sua1(POJO.DTO_CTPN ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("update chitietpn set soluong='{1}' , dongia={2}, thanhtien={3} where mapn={0} and tensp=N'{4}'", ncc.Mapn, ncc.Sl, ncc.Dongia, ncc.Thanhtien, ncc.Tensp);
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
        public bool xoa1(POJO.DTO_CTPN ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("delete chitietpn where mapn={0} and tensp=N'{1}'", ncc.Mapn, ncc.Tensp);
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
