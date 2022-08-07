using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POJO
{
    public class DTO_PN
    {
        private int mapn;

        public int Mapn
        {
            get { return mapn; }
            set { mapn = value; }
        }

        private string mancc;

        public string Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }

        private int tongtien;

        public int Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public DTO_PN()
        {
        }
        public DTO_PN(int mapn, string mancc, int tongtien)
        {
            this.Mapn = mapn;
            this.Mancc = mancc;
            this.Tongtien = tongtien;
        }
    }
}
