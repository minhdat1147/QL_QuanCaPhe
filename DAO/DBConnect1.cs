using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DBConnect1
    {
        private SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }
        private string _strConnect, _strServerName, _strDBName, _strUser, _strPassword;

        public string StrPassword
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }

        public string StrUser
        {
            get { return _strUser; }
            set { _strUser = value; }
        }

        public string StrDBName
        {
            get { return _strDBName; }
            set { _strDBName = value; }
        }

        public string StrServerName
        {
            get { return _strServerName; }
            set { _strServerName = value; }
        }

        public string StrConnect
        {
            get { return _strConnect; }
            set { _strConnect = value; }
        }
        public DBConnect1()
        {
            StrServerName = @"DESKTOP-SOF5J9B\SQLEXPRESS";
            StrDBName = "QL_QUANCAPHE";
            StrConnect = "Data Source=" + StrServerName + "; Initial Catalog=" + StrDBName + "; Integrated Security=True";
            Conn = new SqlConnection(StrConnect);
        }
        public DBConnect1(string strconnect, string strservername, string strdbname, string struser, string strpassword)
        {
            StrConnect = strconnect;
            StrServerName = strservername;
            StrDBName = strdbname;
            StrUser = struser;
            StrPassword = strpassword;
            StrConnect = "Data Source=" + StrServerName + "; Initial Catalog=" + StrDBName + "; Integrated Security=True";
            Conn = new SqlConnection(StrConnect);
        }
        public void openConnection()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }
        public void closeConnection()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }
        public void updateDatabase(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
            closeConnection();
        }
        public SqlDataReader getDataReader(String strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = strSQL;
            SqlDataReader data = cmd.ExecuteReader();

            return data;

        }
    }
}
