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
		public DataSet LayQuestion()
		{
			return db.ExecuteQueryDataSet("select * from Easy", CommandType.Text);
		}
	}
}
