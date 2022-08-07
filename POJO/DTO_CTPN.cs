using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POJO
{
    public class DTO_CTPN
    {
        private int mapn;

        public int Mapn
        {
            get { return mapn; }
            set { mapn = value; }
        }
        private string tensp;

        public string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }
        private int sl;

        public int Sl
        {
            get { return sl; }
            set { sl = value; }
        }
        private int dongia;

        public int Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        private int thanhtien;

        public int Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        public DTO_CTPN()
        {
        }
        public DTO_CTPN(int mapn,string tensp,int sl,int dongia,int thanhtien)
        {
            this.Mapn = mapn;
            this.Tensp = tensp;
            this.Sl = sl;
            this.Dongia = dongia;
            this.Thanhtien = thanhtien;
        }
    }
}
