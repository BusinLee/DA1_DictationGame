using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DA1_DictationGame.DB_Layer;
using System.Windows.Forms;

namespace DA1_DictationGame.BS_layer
{
	class BSMain
	{
		DAL db = null;
		public BSMain()
		{
			db = new DAL();
		}
		public DataSet LayQuestion1()
		{
			return db.ExecuteQueryDataSet("select * from Easy", CommandType.Text);
		}
        public DataSet LayQuestion2()
        {
            return db.ExecuteQueryDataSet("select * from Normal", CommandType.Text);
        }
        public DataSet LayQuestion3()
        {
            return db.ExecuteQueryDataSet("select * from Hard", CommandType.Text);
        }
		public int CountEasy()
		{
			string sqlString = "SELECT Count(*) FROM Easy ";
			return db.Count(sqlString, CommandType.Text);
		}
		public int CountNormal()
		{
			string sqlString = "SELECT Count(*) FROM Normal ";
			return db.Count(sqlString, CommandType.Text);
		}
		public int CountHard()
		{
			string sqlString = "SELECT Count(*) FROM Hard ";
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
		public bool Question(string Word, byte[] hinh)
		{
			return db.MyExecuteNonQuery("spInsertQuesTion", CommandType.StoredProcedure,
				new SqlParameter("@word", Word),
				new SqlParameter("@pic", hinh));
		}
		public bool QuestionNormal(string Word, byte[] hinh)
		{
			return db.MyExecuteNonQuery("spInsertQuesTionNormal", CommandType.StoredProcedure,
				new SqlParameter("@word", Word),
				new SqlParameter("@pic", hinh));
		}
		public bool QuestionHard(string Word, byte[] hinh)
		{
			return db.MyExecuteNonQuery("spInsertQuesTionHard", CommandType.StoredProcedure,
				new SqlParameter("@word", Word),
				new SqlParameter("@pic", hinh));
		}
	}
}
