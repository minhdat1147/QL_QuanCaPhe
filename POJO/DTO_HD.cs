using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POJO
{
    public class DTO_HD
    {
        private int mahd;

        public int Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
 
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }

        private int tongtien;

        public int Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
 
        
        public DTO_HD()
        {
        }
        public DTO_HD(int mahd, string makh, int tongtien)
        {
            this.Mahd = mahd;
            this.Makh = makh;
            this.Tongtien = tongtien;

        }
    }
}
