namespace Game_Flappy_San
{
    partial class Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.picOver = new System.Windows.Forms.PictureBox();
            this.picReStart = new System.Windows.Forms.PictureBox();
            this.picSound = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picSan = new System.Windows.Forms.PictureBox();
            this.picTreeBot2 = new System.Windows.Forms.PictureBox();
            this.picTreeTop2 = new System.Windows.Forms.PictureBox();
            this.picTreeBot1 = new System.Windows.Forms.PictureBox();
            this.picTreeTop1 = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeBot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeBot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Alexandria", 20F);
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(12, 18);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(68, 29);
            this.lbScore.TabIndex = 7;
            this.lbScore.Text = "Score";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picOver
            // 
            this.picOver.BackColor = System.Drawing.Color.Transparent;
            this.picOver.Image = ((System.Drawing.Image)(resources.GetObject("picOver.Image")));
            this.picOver.Location = new System.Drawing.Point(30, 490);
            this.picOver.Name = "picOver";
            this.picOver.Size = new System.Drawing.Size(10, 10);
            this.picOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOver.TabIndex = 10;
            this.picOver.TabStop = false;
            // 
            // picReStart
            // 
            this.picReStart.BackColor = System.Drawing.Color.Transparent;
            this.picReStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReStart.Image = ((System.Drawing.Image)(resources.GetObject("picReStart.Image")));
            this.picReStart.Location = new System.Drawing.Point(474, 92);
            this.picReStart.Name = "picReStart";
            this.picReStart.Size = new System.Drawing.Size(25, 25);
            this.picReStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReStart.TabIndex = 9;
            this.picReStart.TabStop = false;
            this.picReStart.Click += new System.EventHandler(this.picReStart_Click);
            // 
            // picSound
            // 
            this.picSound.BackColor = System.Drawing.Color.Transparent;
            this.picSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSound.Image = ((System.Drawing.Image)(resources.GetObject("picSound.Image")));
            this.picSound.Location = new System.Drawing.Point(474, 62);
            this.picSound.Name = "picSound";
            this.picSound.Size = new System.Drawing.Size(25, 25);
            this.picSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSound.TabIndex = 8;
            this.picSound.TabStop = false;
            this.picSound.Click += new System.EventHandler(this.picSound_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(474, 2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(25, 25);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 6;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picSan
            // 
            this.picSan.BackColor = System.Drawing.Color.Blue;
            this.picSan.Image = global::Game_Flappy_San.Properties.Resources.san;
            this.picSan.Location = new System.Drawing.Point(2, 191);
            this.picSan.Name = "picSan";
            this.picSan.Size = new System.Drawing.Size(70, 70);
            this.picSan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSan.TabIndex = 4;
            this.picSan.TabStop = false;
            // 
            // picTreeBot2
            // 
            this.picTreeBot2.BackColor = System.Drawing.Color.Transparent;
            this.picTreeBot2.Image = ((System.Drawing.Image)(resources.GetObject("picTreeBot2.Image")));
            this.picTreeBot2.Location = new System.Drawing.Point(270, 274);
            this.picTreeBot2.Name = "picTreeBot2";
            this.picTreeBot2.Size = new System.Drawing.Size(90, 400);
            this.picTreeBot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTreeBot2.TabIndex = 3;
            this.picTreeBot2.TabStop = false;
            // 
            // picTreeTop2
            // 
            this.picTreeTop2.BackColor = System.Drawing.Color.Transparent;
            this.picTreeTop2.Image = ((System.Drawing.Image)(resources.GetObject("picTreeTop2.Image")));
            this.picTreeTop2.Location = new System.Drawing.Point(270, -268);
            this.picTreeTop2.Name = "picTreeTop2";
            this.picTreeTop2.Size = new System.Drawing.Size(90, 400);
            this.picTreeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTreeTop2.TabIndex = 2;
            this.picTreeTop2.TabStop = false;
            // 
            // picTreeBot1
            // 
            this.picTreeBot1.BackColor = System.Drawing.Color.Transparent;
            this.picTreeBot1.Image = ((System.Drawing.Image)(resources.GetObject("picTreeBot1.Image")));
            this.picTreeBot1.Location = new System.Drawing.Point(125, 274);
            this.picTreeBot1.Name = "picTreeBot1";
            this.picTreeBot1.Size = new System.Drawing.Size(90, 400);
            this.picTreeBot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTreeBot1.TabIndex = 1;
            this.picTreeBot1.TabStop = false;
            // 
            // picTreeTop1
            // 
            this.picTreeTop1.BackColor = System.Drawing.Color.Transparent;
            this.picTreeTop1.Image = ((System.Drawing.Image)(resources.GetObject("picTreeTop1.Image")));
            this.picTreeTop1.Location = new System.Drawing.Point(125, -268);
            this.picTreeTop1.Name = "picTreeTop1";
            this.picTreeTop1.Size = new System.Drawing.Size(90, 400);
            this.picTreeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTreeTop1.TabIndex = 0;
            this.picTreeTop1.TabStop = false;
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(474, 32);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(25, 25);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 11;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.picSan);
            this.Controls.Add(this.picOver);
            this.Controls.Add(this.picReStart);
            this.Controls.Add(this.picSound);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picTreeBot2);
            this.Controls.Add(this.picTreeTop2);
            this.Controls.Add(this.picTreeBot1);
            this.Controls.Add(this.picTreeTop1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Demo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Demo_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Demo_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Demo_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Demo_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeBot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeBot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTreeTop1;
        private System.Windows.Forms.PictureBox picTreeBot1;
        private System.Windows.Forms.PictureBox picTreeTop2;
        private System.Windows.Forms.PictureBox picTreeBot2;
        private System.Windows.Forms.PictureBox picSan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox picSound;
        private System.Windows.Forms.PictureBox picReStart;
        private System.Windows.Forms.PictureBox picOver;
        private System.Windows.Forms.PictureBox picBack;
    }
}

