using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POJO
{
    public class DTO_KH
    {
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string tenkh;

        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
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
        public DTO_KH()
        {

        }
        public DTO_KH(string makh, string tenkh, string diachi, string sdt)
        {
            this.Makh = makh;
            this.Tenkh = tenkh;
            this.Diachi = diachi;
            this.Sdt = sdt;
        }
    }
}
