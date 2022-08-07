using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QL_QuanCaPhe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static String ten = "";

        public static String mancc = "";
        public static String tenncc = "";

        public static String makh = "";
        public static String tenkh = "";
        public static String gtinh = "";
        public static String sdt = "";

        public static int mahd = 0;
        public static int mapn = 0;

        public static String TK = "";
        public static String MK = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDoUong());
        }
    }
}
