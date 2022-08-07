using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POJO
{
    public class DTO_DOUONG
    {
        private string madu;

        public string Madu
        {
            get { return madu; }
            set { madu = value; }
        }
        private string tendu;

        public string Tendu
        {
            get { return tendu; }
            set { tendu = value; }
        }
        private string dvt;

        public string Dvt
        {
            get { return dvt; }
            set { dvt = value; }
        }
        private int dongia;

        public int Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        private string maloai;

        public string Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }
        public DTO_DOUONG()
        { 
        }
        public DTO_DOUONG(string madu,string tendu,string dvt,int dongia,string maloai)
        {
            this.Madu=madu;
            this.Tendu = tendu;
            this.Dvt = dvt;
            this.Dongia = dongia;
            this.Maloai = maloai;
        }
    }
}
