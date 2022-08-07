using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POJO
{
    public class DTO_CTHD
    {
        private int mahd;

        public int Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        private string tendu;

        public string Tendu
        {
            get { return tendu; }
            set { tendu = value; }
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
        public DTO_CTHD()
        {
        }
        public DTO_CTHD(int mahd,string tendu,int sl,int dongia,int thanhtien)
        {
            this.Mahd = mahd;
            this.Tendu = tendu;
            this.Sl = sl;
            this.Dongia = dongia;
            this.Thanhtien = thanhtien;
        }
    }
}
