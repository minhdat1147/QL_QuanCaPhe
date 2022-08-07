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
    public class BUS_DOUONG
    {
        DAL_DOUONG du = new DAL_DOUONG();
        public DataTable getLoaiSanPham()
        {
            return du.getLoaiSanPham();
        }
        public bool them(POJO.DTO_DOUONG a)
        {
            return du.them(a);
        }
        public bool sua(POJO.DTO_DOUONG a)
        {
            return du.sua(a);
        }
        public bool xoa(string a)
        {
            return du.xoa(a);
        }
        public DataTable timkiem(string maloai)
        {
            return du.Timkiem(maloai);
        }
        public DataTable timkiem1(string madu)
        {
            return du.Timkiem1(madu);
        }
    }
}
