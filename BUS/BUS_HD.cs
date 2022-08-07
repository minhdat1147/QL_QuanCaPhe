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
    public class BUS_HD
    {
        DAL_HD hd = new DAL_HD();
        public DataTable timkiem(string makh)
        {
            return hd.Timkiem(makh);
        }
        public bool them(POJO.DTO_CTHD a)
        {
            return hd.them(a);
        }
        public DataTable timkiem1(int mahd)
        {
            return hd.Timkiem1(mahd);
        }
        public bool sua(POJO.DTO_HD a)
        {
            return hd.sua(a);
        }
        public bool sua1(POJO.DTO_CTHD a)
        {
            return hd.sua1(a);
        }
        public bool xoa1(POJO.DTO_CTHD a)
        {
            return hd.xoa1(a);
        }
        public DataTable thongke(string ngay)
        {
            return hd.Thongke(ngay);
        }
    }
}
