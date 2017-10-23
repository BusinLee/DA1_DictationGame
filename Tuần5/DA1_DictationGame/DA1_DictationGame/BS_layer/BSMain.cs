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

    }
}
