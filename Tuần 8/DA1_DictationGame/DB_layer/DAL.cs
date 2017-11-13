using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_DictationGame.DB_Layer
{
    class DAL
    {
        string ConnStr = "Data Source=DESKTOP-RLOBTTG\\SQLEXPRESS;Initial Catalog=DA1_DictationGame;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DAL()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
			return ds;
        }
		public bool MyExecuteNonQuery(string strSQL, CommandType ct, params SqlParameter[] param)
		{
			bool f = false;
			if (conn.State == ConnectionState.Open)
				conn.Close();
			conn.Open();
			comm.Parameters.Clear();
			comm.CommandText = strSQL;
			comm.CommandType = ct;
			foreach (SqlParameter p in param)
				comm.Parameters.Add(p);
			try
			{
				comm.ExecuteNonQuery();
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

		//     public bool MyExecuteNonQuery(string strSQL, CommandType ct)
		//     {
		//         bool f = false;
		//         if (conn.State == ConnectionState.Open)
		//             conn.Close();
		//         conn.Open();
		//         comm.CommandText = strSQL;
		//         comm.CommandType = ct;
		//         try
		//         {
		//             comm.ExecuteNonQuery();
		//             f = true;
		//         }
		//         catch (SqlException ex)
		//         {

		//}
		//         finally
		//         {
		//             conn.Close();
		//         }
		//         return f;
		//     }

		public int Count(string strSQL, CommandType ct)
		{
			int f = 0;
			if (conn.State == ConnectionState.Open)
				conn.Close();
			conn.Open();
			comm.CommandText = strSQL;
			comm.CommandType = ct;
			try
			{
				f = Int32.Parse(comm.ExecuteScalar().ToString());
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