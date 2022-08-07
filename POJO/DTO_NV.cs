using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POJO
{
    public class DTO_NV
    {
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string tennv;

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        private string ngaysinh;

        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string gtinh;

        public string Gtinh
        {
            get { return gtinh; }
            set { gtinh = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string cmnd;

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        private string chucvu;

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        public DTO_NV()
        {
        }
        public DTO_NV(string manv, string tennv, string ngaysinh, string gtinh, string diachi, string sdt, string cmnd, string chucvu)
        {
            this.Manv = manv;
            this.Tennv = tennv;
            this.Ngaysinh = ngaysinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
            this.Cmnd = cmnd;
            this.Chucvu = chucvu;
            this.Gtinh = gtinh;
        }
    }
}
