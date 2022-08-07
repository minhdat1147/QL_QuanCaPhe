using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using POJO;
using DAO;
namespace BUS
{
    public class BUS_KH
    {
        DAL_KH ncc = new DAL_KH();
        public DataTable getLoaiSanPham()
        {
            return ncc.getLoaiSanPham();
        }
        public bool them(POJO.DTO_KH a)
        {
            return ncc.them(a);
        }
        public bool sua(POJO.DTO_KH a)
        {
            return ncc.sua(a);
        }
        public bool xoa(string a)
        {
            return ncc.xoa(a);
        }
        public DataTable timkiem(string mancc)
        {
            return ncc.Timkiem(mancc);
        }
    }
}
