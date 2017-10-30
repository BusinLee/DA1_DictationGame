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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.dictationGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.txtScore = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtAnswer = new Bunifu.Framework.UI.BunifuTextbox();
			this.btnSub = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnHint = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnSoff = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnSon = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSub)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnHint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSoff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(41, 13);
			this.bunifuCustomLabel1.TabIndex = 3;
			this.bunifuCustomLabel1.Text = "Score: ";
			// 
			// txtScore
			// 
			this.txtScore.AutoSize = true;
			this.txtScore.BackColor = System.Drawing.Color.DarkOrange;
			this.txtScore.Location = new System.Drawing.Point(646, 6);
			this.txtScore.Name = "txtScore";
			this.txtScore.Size = new System.Drawing.Size(25, 13);
			this.txtScore.TabIndex = 4;
			this.txtScore.Text = "000";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(64, 44);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(663, 221);
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
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
			this.bunifuImageButton1.Image = global::DA1_DictationGame.Properties.Resources.Sub;
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(699, 391);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(42, 42);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 14;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(1)))));
			this.BackgroundImage = global::DA1_DictationGame.Properties.Resources.Bia;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.bunifuImageButton1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSon);
			this.Controls.Add(this.btnSoff);
			this.Controls.Add(this.btnHint);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnSub);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtScore);
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
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomLabel txtScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTextbox txtAnswer;
        private Bunifu.Framework.UI.BunifuImageButton btnSub;
        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private Bunifu.Framework.UI.BunifuImageButton btnHint;
        private Bunifu.Framework.UI.BunifuImageButton btnSoff;
        private Bunifu.Framework.UI.BunifuImageButton btnSon;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
	}
}

