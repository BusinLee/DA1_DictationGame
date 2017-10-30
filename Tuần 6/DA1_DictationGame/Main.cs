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
using System.Data.SqlClient;
using System.Speech.Synthesis;
using WMPLib;
using BusinessLogicLayer;


namespace DA1_DictationGame
{
    public partial class Main : Form
    {
        DataTable dtMain = null;
        MainDB dbMain = new MainDB();
        int[] Temp = new int[10];
        int gt, i = 0, row = 0;
        public static int level = 0;
		WindowsMediaPlayer player = new WindowsMediaPlayer();
		MemoryStream ms;
		byte[] arrImage;
		int hint = 0;
		int c = 0;
		string lv;
		public Main()
        {
            InitializeComponent();
			player.URL = "C:\\Users\\Busin Lee\\Desktop\\DA1_DictationGame\\Ballade-For-Adeline-Richard-Clayderman.mp3";
		}

        void LoadData()
        {

            btnStart.Visible = false;
            txtAnswer.Visible = true;
            btnPlay.Visible = true;
            btnHint.Visible = true;
            btnSub.Visible = true;
			lbHint.Visible = true;
            try
            {
                //th
                dtMain = new DataTable();
                dtMain.Clear();
				lbName.Text = Level.name;
                switch (level)
                {
                    case 1:
                        row = 0;
                        c = dbMain.CountEasy();
                        lv = "Easy";
                        dtMain = dbMain.LayQuestion1();
                        break;
                    case 2:
                        row = 1;
                        c = dbMain.CountNormal();
                        lv = "Normal";
                        dtMain = dbMain.LayQuestion2();
                        break;
                    case 3:
                        row = 2;
                        c = dbMain.CountHard();
                        lv = "Hard";
                        dtMain = dbMain.LayQuestion3();
                        break;
                }
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
                    gt = rd.Next(0, c);
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
                        }
                        count = 0;
                    }
                }
            }
            i = 0;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
			player.controls.pause();
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
			Application.Exit();
		}

        private void Main_Load(object sender, EventArgs e)
        {
            txtAnswer.Visible = false;
            btnPlay.Visible = false;
            btnHint.Visible = false;
            btnSub.Visible = false;
            pictureBox1.Visible = false;
            btnNext.Visible = false;
            btnTrue.Visible = false;
            btnFalse.Visible = false;
			lbHint.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            i++;
			txtAnswer.text = "Answer";
            btnNext.Visible = false;
            btnTrue.Visible = false;
            btnFalse.Visible = false;
			pictureBox1.Visible = false;
			btnHint.Enabled = true;
			if (i==10)
			{
				timer1.Stop();
				dtMain = new DataTable();
				dtMain.Clear();
                dtMain = dbMain.LayScore();
			
				if (Int32.Parse(txtSecond.Text) < Int32.Parse(dtMain.Rows[level-1]["Score"].ToString()) )
				{
					dbMain.High(lv, lbName.Text, Int32.Parse(txtSecond.Text));
				}
				DialogResult reply =MessageBox.Show("You complete this level : " + txtSecond.Text + " s", "Kết quả", MessageBoxButtons.RetryCancel);
				if (reply == DialogResult.Retry)
				{
					i = 0;
					txtAnswer.Visible = false;
					btnPlay.Visible = false;
					btnHint.Visible = false;
					btnSub.Visible = false;
					pictureBox1.Visible = false;
					btnNext.Visible = false;
					btnTrue.Visible = false;
					btnFalse.Visible = false;
					lbHint.Visible = false;
					btnStart.Visible = true;
					for (int j=0;j<10;j++)
					{
						Temp[j] = -1;
					}
					txtSecond.Text = "00";
					level = 0;
				}
				if (reply == DialogResult.Cancel)
				{
					Application.Exit();
				}
			}
		}

        private void btnSub_Click(object sender, EventArgs e)
        {
      
            if (txtAnswer.text.ToLower().Equals(dtMain.Rows[Temp[i]]["Word"].ToString().ToLower()))
            {
                btnTrue.Visible = true;
                btnNext.Visible = true;
                btnFalse.Visible = false;
            }
            else
            {
                btnFalse.Visible = true;
                txtAnswer.Focus();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
			if (level == 0)
				MessageBox.Show("Vui lòng chọn level!!!!");
			else
			{
				LoadData();
				timer1.Start();
			}
        }

		private void btnSon_Click(object sender, EventArgs e)
		{
			player.controls.stop();
		}

		private void btnSoff_Click(object sender, EventArgs e)
		{
			player.controls.play();
		}

		private void btnHint_Click(object sender, EventArgs e)
		{
			hint++;
			pictureBox1.Visible = true;
			_hinh = (byte[])dtMain.Rows[Temp[i]]["Picture"];
			if (hint == 3)
			{
				btnHint.Hide();
				lbHint.Hide();
			}
			lbHint.Text = (3 - hint).ToString();
			btnHint.Enabled = false;
		}

		private void txtAnswer_MouseClick(object sender, MouseEventArgs e)
        {
            txtAnswer.text = "";
			if (player.status == "Paused")
				player.controls.play();
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			int se = Int32.Parse(txtSecond.Text);
			se++;
			if (se > 9999)
			{
				DialogResult reply = MessageBox.Show("You complete this level: " + txtSecond.Text + " s", "Kết quả", MessageBoxButtons.RetryCancel);
				if (reply == DialogResult.Retry)
				{
					i = 0;
					txtAnswer.Visible = false;
					btnPlay.Visible = false;
					btnHint.Visible = false;
					btnSub.Visible = false;
					pictureBox1.Visible = false;
					btnNext.Visible = false;
					btnTrue.Visible = false;
					btnFalse.Visible = false;
					lbHint.Visible = false;
					btnStart.Visible = true;
					for (int j = 0; j < 10; j++)
					{
						Temp[j] = -1;
					}
					txtSecond.Text = "00";
					level = 0;
				}
				if (reply == DialogResult.Cancel)
				{
					Application.Exit();
				}
			}
			txtSecond.Text = se.ToString();
		}

		public byte[] _hinh
		{
			set
			{
				arrImage = value;
				ms = new MemoryStream(arrImage);
				pictureBox1.Image = Image.FromStream(ms);

				ms.Close();
			}

		}

	}
}
