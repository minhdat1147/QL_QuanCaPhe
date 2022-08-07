using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POJO;
using DAO;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class BUS_NV
    {
        DAL_NV du = new DAL_NV();
        public DataTable getLoaiSanPham()
        {
            return du.getLoaiSanPham();
        }
        public bool them(POJO.DTO_NV a)
        {
            return du.them(a);
        }
        public bool sua(POJO.DTO_NV a)
        {
            return du.sua(a);
        }
        public bool xoa(string a)
        {
            return du.xoa(a);
        }
        //public DataTable DangNhap(string manv,string sdt)
        //{
        //    //return du.DangNhap(manv,sdt);
        //}
    }
}
