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
    public class BUS_LSP
    {
        DAL_LSP lsp = new DAL_LSP();
        public DataTable getLoaiSanPham()
        {
            return lsp.getLoaiSanPham();
        }
        public bool them(POJO.DTO_LSP sp)
        {
            return lsp.them(sp);
        }
        public bool sua(POJO.DTO_LSP sp)
        {
            return lsp.sua(sp);
        }
        public bool xoa(string maloai)
        {
            return lsp.xoa(maloai);
        }
        public DataTable timkiem(string maloai)
        {
            return lsp.Timkiem(maloai);
        }
    }
}
