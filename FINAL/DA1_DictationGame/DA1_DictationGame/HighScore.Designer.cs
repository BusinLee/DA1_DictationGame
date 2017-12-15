namespace DA1_DictationGame
{
    partial class HighScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScore));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbNameE = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbNameN = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbNameH = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbScoreE = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbScoreN = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbScoreH = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.DarkOrange;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(400, 90);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "HIGH SCORE";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(376, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(38, 143);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(114, 42);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Easy:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(38, 271);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(114, 42);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Normal:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(38, 419);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(114, 42);
            this.bunifuCustomLabel4.TabIndex = 11;
            this.bunifuCustomLabel4.Text = "Hard:";
            // 
            // lbNameE
            // 
            this.lbNameE.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameE.Location = new System.Drawing.Point(38, 199);
            this.lbNameE.Name = "lbNameE";
            this.lbNameE.Size = new System.Drawing.Size(188, 42);
            this.lbNameE.TabIndex = 12;
            this.lbNameE.Text = "Name";
            // 
            // lbNameN
            // 
            this.lbNameN.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameN.Location = new System.Drawing.Point(38, 485);
            this.lbNameN.Name = "lbNameN";
            this.lbNameN.Size = new System.Drawing.Size(188, 42);
            this.lbNameN.TabIndex = 13;
            this.lbNameN.Text = "Name";
            // 
            // lbNameH
            // 
            this.lbNameH.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameH.Location = new System.Drawing.Point(39, 329);
            this.lbNameH.Name = "lbNameH";
            this.lbNameH.Size = new System.Drawing.Size(188, 42);
            this.lbNameH.TabIndex = 14;
            this.lbNameH.Text = "Name";
            // 
            // lbScoreE
            // 
            this.lbScoreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreE.Location = new System.Drawing.Point(212, 199);
            this.lbScoreE.Name = "lbScoreE";
            this.lbScoreE.Size = new System.Drawing.Size(188, 42);
            this.lbScoreE.TabIndex = 15;
            this.lbScoreE.Text = "Name";
            // 
            // lbScoreN
            // 
            this.lbScoreN.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreN.Location = new System.Drawing.Point(212, 485);
            this.lbScoreN.Name = "lbScoreN";
            this.lbScoreN.Size = new System.Drawing.Size(188, 42);
            this.lbScoreN.TabIndex = 16;
            this.lbScoreN.Text = "Name";
            // 
            // lbScoreH
            // 
            this.lbScoreH.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreH.Location = new System.Drawing.Point(212, 329);
            this.lbScoreH.Name = "lbScoreH";
            this.lbScoreH.Size = new System.Drawing.Size(188, 42);
            this.lbScoreH.TabIndex = 17;
            this.lbScoreH.Text = "Name";
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.lbScoreH);
            this.Controls.Add(this.lbScoreN);
            this.Controls.Add(this.lbScoreE);
            this.Controls.Add(this.lbNameH);
            this.Controls.Add(this.lbNameN);
            this.Controls.Add(this.lbNameE);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mix);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNameH;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNameN;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNameE;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuCustomLabel lbScoreH;
		private Bunifu.Framework.UI.BunifuCustomLabel lbScoreN;
		private Bunifu.Framework.UI.BunifuCustomLabel lbScoreE;
	}
}