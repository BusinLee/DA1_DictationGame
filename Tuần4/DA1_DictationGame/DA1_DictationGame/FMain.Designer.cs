namespace DA1_DictationGame
{
	partial class FMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dictationGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkOrange;
			this.panel1.Controls.Add(this.bunifuFlatButton1);
			this.panel1.Controls.Add(this.menuStrip1);
			this.panel1.Location = new System.Drawing.Point(-2, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(621, 71);
			this.panel1.TabIndex = 0;
			// 
			// bunifuFlatButton1
			// 
			this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
			this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 0;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0D;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 90D;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new System.Drawing.Point(586, 6);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(32, 31);
			this.bunifuFlatButton1.TabIndex = 1;
			this.bunifuFlatButton1.Text = "bunifuFlatButton1";
			this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictationGameToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(621, 37);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dictationGameToolStripMenuItem
			// 
			this.dictationGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.highScoreToolStripMenuItem,
            this.importQuestionToolStripMenuItem});
			this.dictationGameToolStripMenuItem.Name = "dictationGameToolStripMenuItem";
			this.dictationGameToolStripMenuItem.Size = new System.Drawing.Size(98, 33);
			this.dictationGameToolStripMenuItem.Text = "DictationGame";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			// 
			// highScoreToolStripMenuItem
			// 
			this.highScoreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.highScoreToolStripMenuItem.Name = "highScoreToolStripMenuItem";
			this.highScoreToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.highScoreToolStripMenuItem.Text = "High Score";
			// 
			// importQuestionToolStripMenuItem
			// 
			this.importQuestionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.importQuestionToolStripMenuItem.Name = "importQuestionToolStripMenuItem";
			this.importQuestionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.importQuestionToolStripMenuItem.Text = "Import Question";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 33);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.pictureBox1.Location = new System.Drawing.Point(185, 91);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(257, 194);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// bunifuFlatButton2
			// 
			this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton2.BackColor = System.Drawing.Color.DarkOrange;
			this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton2.BorderRadius = 0;
			this.bunifuFlatButton2.ButtonText = "Voice";
			this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
			this.bunifuFlatButton2.Iconimage_right = null;
			this.bunifuFlatButton2.Iconimage_right_Selected = null;
			this.bunifuFlatButton2.Iconimage_Selected = null;
			this.bunifuFlatButton2.IconMarginLeft = 0;
			this.bunifuFlatButton2.IconMarginRight = 0;
			this.bunifuFlatButton2.IconRightVisible = true;
			this.bunifuFlatButton2.IconRightZoom = 0D;
			this.bunifuFlatButton2.IconVisible = true;
			this.bunifuFlatButton2.IconZoom = 90D;
			this.bunifuFlatButton2.IsTab = false;
			this.bunifuFlatButton2.Location = new System.Drawing.Point(221, 345);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new System.Drawing.Size(101, 57);
			this.bunifuFlatButton2.TabIndex = 3;
			this.bunifuFlatButton2.Text = "Voice";
			this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// bunifuFlatButton3
			// 
			this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton3.BackColor = System.Drawing.Color.DarkOrange;
			this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton3.BorderRadius = 0;
			this.bunifuFlatButton3.ButtonText = "Hint";
			this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
			this.bunifuFlatButton3.Iconimage_right = null;
			this.bunifuFlatButton3.Iconimage_right_Selected = null;
			this.bunifuFlatButton3.Iconimage_Selected = null;
			this.bunifuFlatButton3.IconMarginLeft = 0;
			this.bunifuFlatButton3.IconMarginRight = 0;
			this.bunifuFlatButton3.IconRightVisible = true;
			this.bunifuFlatButton3.IconRightZoom = 0D;
			this.bunifuFlatButton3.IconVisible = true;
			this.bunifuFlatButton3.IconZoom = 90D;
			this.bunifuFlatButton3.IsTab = false;
			this.bunifuFlatButton3.Location = new System.Drawing.Point(522, 487);
			this.bunifuFlatButton3.Name = "bunifuFlatButton3";
			this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton3.selected = false;
			this.bunifuFlatButton3.Size = new System.Drawing.Size(85, 51);
			this.bunifuFlatButton3.TabIndex = 4;
			this.bunifuFlatButton3.Text = "Hint";
			this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// bunifuFlatButton4
			// 
			this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton4.BackColor = System.Drawing.Color.DarkOrange;
			this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton4.BorderRadius = 0;
			this.bunifuFlatButton4.ButtonText = "Check";
			this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton4.Iconimage = global::DA1_DictationGame.Properties.Resources._22472511_1880860292228104_2120996451_n;
			this.bunifuFlatButton4.Iconimage_right = null;
			this.bunifuFlatButton4.Iconimage_right_Selected = null;
			this.bunifuFlatButton4.Iconimage_Selected = null;
			this.bunifuFlatButton4.IconMarginLeft = 0;
			this.bunifuFlatButton4.IconMarginRight = 0;
			this.bunifuFlatButton4.IconRightVisible = true;
			this.bunifuFlatButton4.IconRightZoom = 0D;
			this.bunifuFlatButton4.IconVisible = true;
			this.bunifuFlatButton4.IconZoom = 90D;
			this.bunifuFlatButton4.IsTab = false;
			this.bunifuFlatButton4.Location = new System.Drawing.Point(331, 345);
			this.bunifuFlatButton4.Name = "bunifuFlatButton4";
			this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton4.selected = false;
			this.bunifuFlatButton4.Size = new System.Drawing.Size(111, 57);
			this.bunifuFlatButton4.TabIndex = 5;
			this.bunifuFlatButton4.Text = "Check";
			this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// bunifuTextbox1
			// 
			this.bunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
			this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuTextbox1.ForeColor = System.Drawing.Color.DarkOrange;
			this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
			this.bunifuTextbox1.Location = new System.Drawing.Point(221, 291);
			this.bunifuTextbox1.Name = "bunifuTextbox1";
			this.bunifuTextbox1.Size = new System.Drawing.Size(221, 43);
			this.bunifuTextbox1.TabIndex = 6;
			this.bunifuTextbox1.text = "Please type your answer here...";
			// 
			// FMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::DA1_DictationGame.Properties.Resources._22414614_1880855665561900_359884902_n;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(619, 550);
			this.Controls.Add(this.bunifuTextbox1);
			this.Controls.Add(this.bunifuFlatButton4);
			this.Controls.Add(this.bunifuFlatButton3);
			this.Controls.Add(this.bunifuFlatButton2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FMain";
			this.Text = "FMain";
			this.panel1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dictationGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem highScoreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importQuestionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
	}
}