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
using System.IO;
using DA1_DictationGame.BS_layer;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace DA1_DictationGame
{
    public partial class Main : Form
    {
		DataTable dtMain = null;
		BSMain dbMain = new BSMain();
		int[] Temp = new int[10];
		int gt , i = 0;
		public Main()
        {
            InitializeComponent();
			//txtAnswer.text = "Answer";
        }

		void LoadData()
		{
			try
			{
				dtMain = new DataTable();
				dtMain.Clear();
				DataSet ds = dbMain.LayQuestion();
				dtMain = ds.Tables[0];

			}
			catch (SqlException)
			{
				MessageBox.Show("Không lấy được nội dung trong table DA1. Lỗi rồi!!!");
			}

			Random rd = new Random();
			Boolean t = false;
			int count = 0;
			for (i = 0; i < 10; i++)
			{
				t = false;
				
				while (t == false)
				{
					gt = rd.Next(0, 10);
					if (i == 0)
					{
						Temp[0] = gt;
						t = true;
					}
					else
					{
						for (int j = 0; j < i; j++)
						{
							if (gt != Temp[j])
								count++;
						}
						if (count == (i))
						{
							Temp[i] = gt;
							t = true;
							//MessageBox.Show(Temp[i].ToString());
						}
						count = 0;
					}
				}
			}
			i = 0;
		}
		
		private void btnPlay_Click(object sender, EventArgs e)
		{
			SpeechSynthesizer synthesizer = new SpeechSynthesizer();
			synthesizer.Volume = 100;  // 0...100
			synthesizer.Rate = 0;     // -10...10
			synthesizer.SpeakAsync(dtMain.Rows[Temp[i]]["Word"].ToString());
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help form = new Help();
            form.Show();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Level form = new Level();
            form.Show();
        }

        private void highScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScore form = new HighScore();
            form.Show();
        }

        private void importQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import form = new Import();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

		private void Main_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			i++;
		}

		private void btnSub_Click(object sender, EventArgs e)
		{
			if (txtAnswer.text == dtMain.Rows[Temp[i]]["Word"].ToString())
			{
				MessageBox.Show("Right!!!");
			}
			else
			{
				MessageBox.Show("Type again!!!");
				txtAnswer.Focus();
			}
		}

		

		private void txtAnswer_MouseClick(object sender, MouseEventArgs e)
		{
			txtAnswer.text = "";
		}
		
	}
}
