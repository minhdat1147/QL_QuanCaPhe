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
    public class BUS_NCC
    {
        DAL_NCC ncc = new DAL_NCC();
        public DataTable getLoaiSanPham()
        {
            return ncc.getLoaiSanPham();
        }
        public bool them(POJO.DTO_NCC a)
        {
            return ncc.them(a);
        }
        public bool sua(POJO.DTO_NCC a)
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
