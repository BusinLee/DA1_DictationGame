using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class MainDB
    {
        DataProvider db = null;
        public MainDB()
        {
            db = new DataProvider();
        }

        //có hết mấy hàm cần r này
        public DataTable LayQuestion1()
        {
            return db.ExecuteQueryDataTable("select * from Easy", CommandType.Text);
        }
        public DataTable LayQuestion2()
        {
            return db.ExecuteQueryDataTable("select * from Normal", CommandType.Text);
        }
        public DataTable LayQuestion3()
        {
            return db.ExecuteQueryDataTable("select * from Hard", CommandType.Text);
        }
        public int CountEasy()
        {
            string sqlString = "SELECT Count(*) FROM Easy ";
            return (int) db.ExecuteQueryScalar(sqlString, CommandType.Text);
        }
        public int CountNormal()
        {
            string sqlString = "SELECT Count(*) FROM Normal ";
            return (int)db.ExecuteQueryScalar(sqlString, CommandType.Text);
        }
        public int CountHard()
        {
            string sqlString = "SELECT Count(*) FROM Hard ";
            return (int)db.ExecuteQueryScalar(sqlString, CommandType.Text);
        }
        public DataTable LayScore()//k biết để t kêu nó test lajicais đó, đủ đồ xài r còn import
        {
            return db.ExecuteQueryDataTable("select * from HighScore", CommandType.Text);
        }
        public bool High(string Level, string Name, int Score)
        {
            string sqlString = "Update HighScore Set Name = N'" + Name + " ' , Score = N'" + Score + " ' Where Level ='" + Level + "'";
            return db.ExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool importTuVung(string choose, string word, byte[] images)
        {
            return db.ExecuteNonQuery(
               "Insert into " + choose + " values(@Word, @Pic) ",
                CommandType.Text,

                new SqlParameter("@Word", word),
                new SqlParameter("@Pic", images));
        }
    }
}

