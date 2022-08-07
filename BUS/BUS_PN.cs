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
    public class BUS_PN
    {
        DAL_PN pn = new DAL_PN();
        public DataTable timkiem(string mancc)
        {
            return pn.Timkiem(mancc);
        }
        public bool them(POJO.DTO_CTPN a)
        {
            return pn.them(a);
        }
        public DataTable timkiem1(int mahd)
        {
            return pn.Timkiem1(mahd);
        }
        public bool sua(POJO.DTO_PN a)
        {
            return pn.sua(a);
        }
        public bool sua1(POJO.DTO_CTPN a)
        {
            return pn.sua1(a);
        }
        public bool xoa1(POJO.DTO_CTPN a)
        {
            return pn.xoa1(a);
        }
    }
}
