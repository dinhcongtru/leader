using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sinhvien
{
   public  class ketnoi
    {
        public static string connectionstring = "Data Source=DESKTOP-KLPOHE4\\SQLEXPRESS;Initial Catalog=QLS;Integrated Security=True";
        public static DataTable SelectDB(string sql)
        {
            using (SqlConnection con = new SqlConnection(connectionstring ))
            {
                using (SqlDataAdapter dad = new SqlDataAdapter(sql, con))
                {
                    using (DataSet dst = new DataSet())
                    {
                        dad.Fill(dst);
                        return dst.Tables[0];
                    }
                }
            }
        }
        // update - insert - delete		
        public static void UIDDB(string sql)
        {
            using (SqlConnection con = new SqlConnection(connectionstring ))
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
                con.Dispose();
            }
        }

    }
}
