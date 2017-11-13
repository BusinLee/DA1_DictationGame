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
using DA1_DictationGame.BS_layer;

namespace DA1_DictationGame
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }
		DataTable dtMain = null;
		BSMain dbMain = new BSMain();
		string pic = string.Empty;
        string choose = string.Empty;
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfileDlg = new OpenFileDialog();
            openfileDlg.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openfileDlg.FilterIndex = 1;
            openfileDlg.RestoreDirectory = true;
            if (openfileDlg.ShowDialog() == DialogResult.OK)

            {
                pictureBox.ImageLocation = openfileDlg.FileName;
                pic = openfileDlg.FileName;
            }
        }
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(pic, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            return picbyte;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
				if (choose == "Easy")
				{
					dbMain.Question(txtWord.Text, convertImageToBytes());
					MessageBox.Show("Success");
				}
				else
				{
					if (choose == "Normal")
					{
						dbMain.QuestionNormal(txtWord.Text, convertImageToBytes());
						MessageBox.Show("Success");
					}
					else
					{
						dbMain.QuestionHard(txtWord.Text, convertImageToBytes());
						MessageBox.Show("Success");
					}
				}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Import_Load(object sender, EventArgs e)
        {
            cbbLV.Items.Add("Easy");
            cbbLV.Items.Add("Normal");
            cbbLV.Items.Add("Hard");
            cbbLV.SelectedIndex = 0;
        }

        private void cbbLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            choose = cbbLV.SelectedItem.ToString();
        }
		
	}
}
