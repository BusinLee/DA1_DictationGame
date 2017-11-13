namespace DA1_DictationGame
{
    partial class Import
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.cbbLV = new System.Windows.Forms.ComboBox();
			this.txtWord = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnBrowse = new Bunifu.Framework.UI.BunifuThinButton2();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 5;
			this.bunifuElipse2.TargetControl = this;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.BackColor = System.Drawing.Color.DarkOrange;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(400, 90);
			this.bunifuCustomLabel1.TabIndex = 4;
			this.bunifuCustomLabel1.Text = "Import Question";
			this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(34, 155);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(60, 25);
			this.bunifuCustomLabel2.TabIndex = 6;
			this.bunifuCustomLabel2.Text = "Word";
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.AutoSize = true;
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(34, 230);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(72, 25);
			this.bunifuCustomLabel3.TabIndex = 7;
			this.bunifuCustomLabel3.Text = "Picture";
			// 
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.AutoSize = true;
			this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(34, 295);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(133, 25);
			this.bunifuCustomLabel4.TabIndex = 8;
			this.bunifuCustomLabel4.Text = "Choose Level";
			// 
			// cbbLV
			// 
			this.cbbLV.FormattingEnabled = true;
			this.cbbLV.Location = new System.Drawing.Point(197, 299);
			this.cbbLV.Name = "cbbLV";
			this.cbbLV.Size = new System.Drawing.Size(135, 21);
			this.cbbLV.TabIndex = 11;
			this.cbbLV.SelectedIndexChanged += new System.EventHandler(this.cbbLV_SelectedIndexChanged);
			// 
			// txtWord
			// 
			this.txtWord.BorderColorFocused = System.Drawing.Color.Blue;
			this.txtWord.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtWord.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.txtWord.BorderThickness = 3;
			this.txtWord.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.txtWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtWord.isPassword = false;
			this.txtWord.Location = new System.Drawing.Point(145, 146);
			this.txtWord.Margin = new System.Windows.Forms.Padding(4);
			this.txtWord.Name = "txtWord";
			this.txtWord.Size = new System.Drawing.Size(233, 44);
			this.txtWord.TabIndex = 13;
			this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
			this.btnExit.Image = global::DA1_DictationGame.Properties.Resources.Exit;
			this.btnExit.ImageActive = null;
			this.btnExit.Location = new System.Drawing.Point(376, 0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(24, 24);
			this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnExit.TabIndex = 15;
			this.btnExit.TabStop = false;
			this.btnExit.Zoom = 10;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox.Location = new System.Drawing.Point(39, 372);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(339, 123);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 14;
			this.pictureBox.TabStop = false;
			// 
			// btnAdd
			// 
			this.btnAdd.ActiveBorderThickness = 1;
			this.btnAdd.ActiveCornerRadius = 20;
			this.btnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
			this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
			this.btnAdd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
			this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
			this.btnAdd.ButtonText = "ADD";
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.Black;
			this.btnAdd.IdleBorderThickness = 1;
			this.btnAdd.IdleCornerRadius = 20;
			this.btnAdd.IdleFillColor = System.Drawing.Color.White;
			this.btnAdd.IdleForecolor = System.Drawing.Color.Black;
			this.btnAdd.IdleLineColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(103, 527);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(181, 41);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnBrowse
			// 
			this.btnBrowse.ActiveBorderThickness = 1;
			this.btnBrowse.ActiveCornerRadius = 20;
			this.btnBrowse.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
			this.btnBrowse.ActiveForecolor = System.Drawing.Color.White;
			this.btnBrowse.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
			this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
			this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
			this.btnBrowse.ButtonText = "Browse...";
			this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowse.ForeColor = System.Drawing.Color.Black;
			this.btnBrowse.IdleBorderThickness = 1;
			this.btnBrowse.IdleCornerRadius = 20;
			this.btnBrowse.IdleFillColor = System.Drawing.Color.White;
			this.btnBrowse.IdleForecolor = System.Drawing.Color.Black;
			this.btnBrowse.IdleLineColor = System.Drawing.Color.White;
			this.btnBrowse.Location = new System.Drawing.Point(162, 214);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(5);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(181, 41);
			this.btnBrowse.TabIndex = 10;
			this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnBrowse.Click += new System.EventHandler(this.bunifuThinButton21_Click);
			// 
			// Import
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(400, 600);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.txtWord);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cbbLV);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.bunifuCustomLabel4);
			this.Controls.Add(this.bunifuCustomLabel3);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Import";
			this.Text = "Import";
			this.Load += new System.EventHandler(this.Import_Load);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mix);
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.ComboBox cbbLV;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBrowse;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox pictureBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtWord;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
	}
}