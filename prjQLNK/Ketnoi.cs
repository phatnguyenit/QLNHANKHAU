using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace prjQLNK
{
    class Ketnoi
    {
        public static SqlConnection con;
        //public static string strConnection = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public static string strConnection = "Data Source=.\\sqlexpress;Initial Catalog=QLNK;Integrated Security=True";
        //Data Source=.\sqlexpress;Initial Catalog=QLNK;Integrated Security=True
        public static void Connect()
        {
            try
            {
                con = new SqlConnection(strConnection);
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Disconnect()
        {
            con.Close();
            con.Dispose();
            con = null;
        }
    }
}
