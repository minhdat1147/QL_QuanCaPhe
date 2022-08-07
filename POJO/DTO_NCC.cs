using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POJO
{
    public class DTO_NCC
    {
        private string mancc;

        public string Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }
        private string tenncc;

        public string Tenncc
        {
            get { return tenncc; }
            set { tenncc = value; }
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
        public DTO_NCC()
        {
        }
        public DTO_NCC(string mancc, string tenncc, string diachi, string sdt)
        {
            this.Mancc = mancc;
            this.Tenncc = tenncc;
            this.Diachi = diachi;
            this.Sdt = sdt; 
        }
    }
}
