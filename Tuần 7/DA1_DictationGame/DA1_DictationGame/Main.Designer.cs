namespace DA1_DictationGame
{
    partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.dictationGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtAnswer = new Bunifu.Framework.UI.BunifuTextbox();
			this.btnSub = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnHint = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnSoff = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnSon = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnTrue = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnFalse = new Bunifu.Framework.UI.BunifuImageButton();
			this.txtSecond = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnStart = new Bunifu.Framework.UI.BunifuImageButton();
			this.lbHint = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.lbName = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSub)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnHint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSoff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTrue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFalse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.DarkOrange;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictationGameToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// dictationGameToolStripMenuItem
			// 
			this.dictationGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.highScoreToolStripMenuItem,
            this.importQuestionToolStripMenuItem});
			this.dictationGameToolStripMenuItem.Name = "dictationGameToolStripMenuItem";
			this.dictationGameToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
			this.dictationGameToolStripMenuItem.Text = "DictationGame";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.newGameToolStripMenuItem.Text = "NewGame";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// highScoreToolStripMenuItem
			// 
			this.highScoreToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
			this.highScoreToolStripMenuItem.Name = "highScoreToolStripMenuItem";
			this.highScoreToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.highScoreToolStripMenuItem.Text = "HighScore";
			this.highScoreToolStripMenuItem.Click += new System.EventHandler(this.highScoreToolStripMenuItem_Click);
			// 
			// importQuestionToolStripMenuItem
			// 
			this.importQuestionToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
			this.importQuestionToolStripMenuItem.Name = "importQuestionToolStripMenuItem";
			this.importQuestionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.importQuestionToolStripMenuItem.Text = "Import Question";
			this.importQuestionToolStripMenuItem.Click += new System.EventHandler(this.importQuestionToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.BackColor = System.Drawing.Color.DarkOrange;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(599, 6);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(33, 13);
			this.bunifuCustomLabel1.TabIndex = 3;
			this.bunifuCustomLabel1.Text = "Time:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(64, 44);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(663, 221);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// txtAnswer
			// 
			this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
			this.txtAnswer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAnswer.BackgroundImage")));
			this.txtAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.txtAnswer.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnswer.ForeColor = System.Drawing.Color.Black;
			this.txtAnswer.Icon = ((System.Drawing.Image)(resources.GetObject("txtAnswer.Icon")));
			this.txtAnswer.Location = new System.Drawing.Point(300, 293);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(250, 42);
			this.txtAnswer.TabIndex = 7;
			this.txtAnswer.TabStop = false;
			this.txtAnswer.text = "Answer";
			this.txtAnswer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAnswer_MouseClick);
			// 
			// btnSub
			// 
			this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
			this.btnSub.Image = global::DA1_DictationGame.Properties.Resources.Sub;
			this.btnSub.ImageActive = null;
			this.btnSub.Location = new System.Drawing.Point(616, 293);
			this.btnSub.Name = "btnSub";
			this.btnSub.Size = new System.Drawing.Size(42, 42);
			this.btnSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnSub.TabIndex = 8;
			this.btnSub.TabStop = false;
			this.btnSub.Zoom = 10;
			this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
			this.btnPlay.ErrorImage = null;
			this.btnPlay.Image = global::DA1_DictationGame.Properties.Resources.Play;
			this.btnPlay.ImageActive = null;
			this.btnPlay.Location = new System.Drawing.Point(345, 376);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(71, 71);
			this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnPlay.TabIndex = 9;
			this.btnPlay.TabStop = false;
			this.btnPlay.Zoom = 10;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnHint
			// 
			this.btnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
			this.btnHint.BackgroundImage = global::DA1_DictationGame.Properties.Resources.Hint;
			this.btnHint.ErrorImage = null;
			this.btnHint.Image = global::DA1_DictationGame.Properties.Resources.Hint;
			this.btnHint.ImageActive = null;
			this.btnHint.Location = new System.Drawing.Point(435, 376);
			this.btnHint.Name = "btnHint";
			this.btnHint.Size = new System.Drawing.Size(71, 71);
			this.btnHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnHint.TabIndex = 10;
			this.btnHint.TabStop = false;
			this.btnHint.Zoom = 10;
			this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
			// 
			// btnSoff
			// 
			this.btnSoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
			this.btnSoff.Image = global::DA1_DictationGame.Properties.Resources.Son;
			this.btnSoff.ImageActive = null;
			this.btnSoff.Location = new System.Drawing.Point(587, 517);
			this.btnSoff.Name = "btnSoff";
			this.btnSoff.Size = new System.Drawing.Size(71, 71);
			this.btnSoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnSoff.TabIndex = 11;
			this.btnSoff.TabStop = false;
			this.btnSoff.Zoom = 10;
			this.btnSoff.Click += new System.EventHandler(this.btnSoff_Click);
			// 
			// btnSon
			// 
			this.btnSon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(1)))));
			this.btnSon.Image = global::DA1_DictationGame.Properties.Resources.Soff;
			this.btnSon.ImageActive = null;
			this.btnSon.Location = new System.Drawing.Point(687, 517);
			this.btnSon.Name = "btnSon";
			this.btnSon.Size = new System.Drawing.Size(71, 71);
			this.btnSon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnSon.TabIndex = 12;
			this.btnSon.TabStop = false;
			this.btnSon.Zoom = 10;
			this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
			this.btnExit.Image = global::DA1_DictationGame.Properties.Resources.Exit;
			this.btnExit.ImageActive = null;
			this.btnExit.Location = new System.Drawing.Point(776, 0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(24, 24);
			this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnExit.TabIndex = 13;
			this.btnExit.TabStop = false;
			this.btnExit.Zoom = 10;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
			this.btnNext.Image = global::DA1_DictationGame.Properties.Resources.Next;
			this.btnNext.ImageActive = null;
			this.btnNext.Location = new System.Drawing.Point(699, 391);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(42, 42);
			this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnNext.TabIndex = 14;
			this.btnNext.TabStop = false;
			this.btnNext.Zoom = 10;
			this.btnNext.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// btnTrue
			// 
			this.btnTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
			this.btnTrue.Image = global::DA1_DictationGame.Properties.Resources.True;
			this.btnTrue.ImageActive = null;
			this.btnTrue.Location = new System.Drawing.Point(616, 391);
			this.btnTrue.Name = "btnTrue";
			this.btnTrue.Size = new System.Drawing.Size(42, 42);
			this.btnTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnTrue.TabIndex = 15;
			this.btnTrue.TabStop = false;
			this.btnTrue.Zoom = 10;
			// 
			// btnFalse
			// 
			this.btnFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
			this.btnFalse.Image = global::DA1_DictationGame.Properties.Resources.False;
			this.btnFalse.ImageActive = null;
			this.btnFalse.Location = new System.Drawing.Point(616, 391);
			this.btnFalse.Name = "btnFalse";
			this.btnFalse.Size = new System.Drawing.Size(42, 42);
			this.btnFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnFalse.TabIndex = 16;
			this.btnFalse.TabStop = false;
			this.btnFalse.Zoom = 10;
			// 
			// txtSecond
			// 
			this.txtSecond.AutoSize = true;
			this.txtSecond.BackColor = System.Drawing.Color.DarkOrange;
			this.txtSecond.Location = new System.Drawing.Point(639, 6);
			this.txtSecond.Name = "txtSecond";
			this.txtSecond.Size = new System.Drawing.Size(19, 13);
			this.txtSecond.TabIndex = 17;
			this.txtSecond.Text = "00";
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
			this.btnStart.ErrorImage = null;
			this.btnStart.Image = global::DA1_DictationGame.Properties.Resources.Play;
			this.btnStart.ImageActive = null;
			this.btnStart.Location = new System.Drawing.Point(345, 248);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(71, 71);
			this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnStart.TabIndex = 19;
			this.btnStart.TabStop = false;
			this.btnStart.Zoom = 10;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lbHint
			// 
			this.lbHint.AutoSize = true;
			this.lbHint.Location = new System.Drawing.Point(494, 376);
			this.lbHint.Name = "lbHint";
			this.lbHint.Size = new System.Drawing.Size(13, 13);
			this.lbHint.TabIndex = 21;
			this.lbHint.Text = "3";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.BackColor = System.Drawing.Color.DarkOrange;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(408, 6);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(39, 13);
			this.bunifuCustomLabel2.TabIndex = 22;
			this.bunifuCustomLabel2.Text = "Player:";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.BackColor = System.Drawing.Color.DarkOrange;
			this.lbName.Location = new System.Drawing.Point(453, 6);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(35, 13);
			this.lbName.TabIndex = 23;
			this.lbName.Text = "Name";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(1)))));
			this.BackgroundImage = global::DA1_DictationGame.Properties.Resources.Bia;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.lbHint);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtSecond);
			this.Controls.Add(this.btnFalse);
			this.Controls.Add(this.btnTrue);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSon);
			this.Controls.Add(this.btnSoff);
			this.Controls.Add(this.btnHint);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnSub);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.menuStrip);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Main_Load);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mix);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSub)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnHint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSoff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTrue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFalse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem dictationGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTextbox txtAnswer;
        private Bunifu.Framework.UI.BunifuImageButton btnSub;
        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private Bunifu.Framework.UI.BunifuImageButton btnHint;
        private Bunifu.Framework.UI.BunifuImageButton btnSoff;
        private Bunifu.Framework.UI.BunifuImageButton btnSon;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
		private Bunifu.Framework.UI.BunifuImageButton btnNext;
        private Bunifu.Framework.UI.BunifuImageButton btnTrue;
        private Bunifu.Framework.UI.BunifuImageButton btnFalse;
        private Bunifu.Framework.UI.BunifuCustomLabel txtSecond;
        private Bunifu.Framework.UI.BunifuImageButton btnStart;
		private System.Windows.Forms.Label lbHint;
		private System.Windows.Forms.Timer timer1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuCustomLabel lbName;
	}
}

