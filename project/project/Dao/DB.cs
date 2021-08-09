using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Data;

namespace project.Dao
{
    class DB
    {
        public SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Demo.nnet"].ToString();
            return new SqlConnection(strCon);
        }

        public int ExecuteSQL(string sql, params SqlParameter[] sqlParameters)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, GetConnection());
                cmd.Parameters.AddRange(sqlParameters);
                cmd.Connection.Open();
                int numberRows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return numberRows;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public DataTable getDatabase(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
