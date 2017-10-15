using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1_DictationGame
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfileDlg = new OpenFileDialog();
			openfileDlg.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
			openfileDlg.FilterIndex = 1;
			openfileDlg.RestoreDirectory = true;
			if (openfileDlg.ShowDialog()== DialogResult.OK)

			{
				pictureBox1.ImageLocation = openfileDlg.FileName;
				textBox3.Text = openfileDlg.FileName;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				string ConnStr = @"Data Source=.\MSSQLSERVER1;Initial Catalog=DA1_DictationGame;Integrated Security=True";
				SqlConnection conn = new SqlConnection(ConnStr);
				conn.Open();
				String strCom = "Insert into Hard values(@Id,@Word, @Pic) ";
				//String strCom = "Update Easy SET Id = values(@Id) where Picture = values(@Pic) ";
				SqlCommand com = new SqlCommand(strCom, conn);
				com.Parameters.AddWithValue("@Id", textBox1.Text);
				com.Parameters.AddWithValue("@Word", textBox2.Text);
				com.Parameters.AddWithValue("@Pic", convertImageToBytes());
				

				com.ExecuteNonQuery();
				conn.Close();
				textBox3.Text = textBox2.Text = "";
				MessageBox.Show("Success");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private byte[] convertImageToBytes()
		{
			FileStream fs;
			fs = new FileStream(textBox3.Text, FileMode.Open, FileAccess.Read);
			byte[] picbyte = new byte[fs.Length];
			fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
			return picbyte;
		}
	}
}
