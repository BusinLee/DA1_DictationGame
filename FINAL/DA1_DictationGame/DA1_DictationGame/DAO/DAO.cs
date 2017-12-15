using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DA1_DictationGame.Utils;
using System.Windows.Forms;

namespace DA1_DictationGame.DAO
{
	class BSMain
	{
		DataConnection db = null;
		public BSMain()
		{
			db = new DataConnection();
		}
		public DataSet Question1()
		{
			return db.ExecuteQueryDataSet("select * from Question where Level = 'E'", CommandType.Text);
		}
        public DataSet Question2()
        {
            return db.ExecuteQueryDataSet("select * from Question where Level = 'N'", CommandType.Text);
        }
        public DataSet Question3()
        {
            return db.ExecuteQueryDataSet("select * from Question where Level = 'H'", CommandType.Text);
        }
        public int CountEasy()
		{
			string sqlString = "SELECT Count(*) from Question where Level = 'E' ";
			return db.Count(sqlString, CommandType.Text);
		}
		public int CountNormal()
		{
			string sqlString = "SELECT Count(*) from Question where Level = 'N' ";
			return db.Count(sqlString, CommandType.Text);
		}
		public int CountHard()
		{
			string sqlString = "SELECT Count(*) from Question where Level = 'H' ";
			return db.Count(sqlString, CommandType.Text);
		}
		public DataSet LayScore()
		{
			return db.ExecuteQueryDataSet("select * from HighScore", CommandType.Text);
		}
		public bool High(string Level, string Name, int Score)
		{
			string sqlString = "Update HighScore Set Name = N'" + Name + " ' , Score = N'" + Score + " ' Where Level ='" + Level +  "'";
			return db.MyExecuteNonQuery(sqlString, CommandType.Text);
		}
		public bool Question(string Word, byte[] hinh, string Level)
		{
			return db.MyExecuteNonQuery("spInsertQuesTion", CommandType.StoredProcedure,
				new SqlParameter("@word", Word),
				new SqlParameter("@pic", hinh),
                new SqlParameter("@level", Level));
		}
	}
}
