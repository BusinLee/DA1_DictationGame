using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA1_DictationGame.BS_layer;
using System.Data.SqlClient;

namespace DA1_DictationGame
{
    public partial class HighScore : Form
    {
		DataTable dtMain = null;
		BSMain dbMain = new BSMain();
		public HighScore()
        {
            InitializeComponent();
        }
		void LoadData()
		{

			try
			{

				dtMain = new DataTable();
				dtMain.Clear();
				DataSet ds = dbMain.LayScore();
				dtMain = ds.Tables[0];
				lbNameE.Text = dtMain.Rows[0]["Name"].ToString();
				lbNameN.Text = dtMain.Rows[1]["Name"].ToString();
				lbNameH.Text = dtMain.Rows[2]["Name"].ToString();

				lbScoreE.Text = dtMain.Rows[0]["Score"].ToString();
				lbScoreN.Text = dtMain.Rows[1]["Score"].ToString();
				lbScoreH.Text = dtMain.Rows[2]["Score"].ToString();
			}
			catch (SqlException)
			{
				MessageBox.Show("Không lấy được nội dung trong table HighScore. Lỗi rồi!!!");
			}
			
		}
		private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

         private const int WM_INCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void mix(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_INCLBUTTONDOWN, HTCAPTION, 0);
        }

		private void HighScore_Load(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
