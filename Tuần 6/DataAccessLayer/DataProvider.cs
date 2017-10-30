using System;
using System.Data.SqlClient;
using System.Data;


namespace DataAccessLayer
{
    public class DataProvider
    {
		SqlConnection conn;
		SqlCommand cmd;
		SqlDataAdapter adp;
		SqlConnectionStringBuilder myString;
		public DataProvider()
		{
			myString = new SqlConnectionStringBuilder();
			myString.DataSource = @"DESKTOP-KKTGR4K\MSSQLSERVER1";
			//myString.UserID = "";
			//myString.Password = "admin@123";
			myString.InitialCatalog = "DA1_DictationGame";
			myString.IntegratedSecurity = true;

			conn = new SqlConnection(myString.ConnectionString);
			cmd = conn.CreateCommand();
		}
		// Select query 
		public DataTable ExecuteQueryDataTable(
            string strMySql, CommandType ct)
        {
            cmd.CommandText = strMySql;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public Object ExecuteQueryScalar(
            string strMySql, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strMySql;
            cmd.CommandType = ct;
            return cmd.ExecuteScalar();

        }
        // action query
        public bool ExecuteNonQuery(string strMySql, CommandType ct)
        {
            bool f = false;
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strMySql;
            cmd.CommandType = ct;
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return f;
        }


        public bool ExecuteNonQuery(string strMySql, CommandType ct,
           params SqlParameter[] param)
        {
            bool f = false;
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strMySql;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
              
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
