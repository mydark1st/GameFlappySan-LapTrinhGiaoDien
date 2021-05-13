namespace Game_Flappy_San
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
            this.btPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picSan = new System.Windows.Forms.PictureBox();
            this.btIns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSan)).BeginInit();
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.White;
            this.btPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlay.Font = new System.Drawing.Font("Alexandria", 20F);
            this.btPlay.ForeColor = System.Drawing.Color.Crimson;
            this.btPlay.Location = new System.Drawing.Point(120, 250);
            this.btPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(239, 47);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.BtPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(49, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flappy San";
            // 
            // picSan
            // 
            this.picSan.BackColor = System.Drawing.Color.Transparent;
            this.picSan.Image = global::Game_Flappy_San.Properties.Resources.san;
            this.picSan.Location = new System.Drawing.Point(363, 23);
            this.picSan.Margin = new System.Windows.Forms.Padding(2);
            this.picSan.Name = "picSan";
            this.picSan.Size = new System.Drawing.Size(100, 100);
            this.picSan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSan.TabIndex = 6;
            this.picSan.TabStop = false;
            // 
            // btIns
            // 
            this.btIns.BackColor = System.Drawing.Color.White;
            this.btIns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIns.Font = new System.Drawing.Font("Alexandria", 20F);
            this.btIns.ForeColor = System.Drawing.Color.Crimson;
            this.btIns.Location = new System.Drawing.Point(120, 325);
            this.btIns.Margin = new System.Windows.Forms.Padding(2);
            this.btIns.Name = "btIns";
            this.btIns.Size = new System.Drawing.Size(239, 47);
            this.btIns.TabIndex = 1;
            this.btIns.Text = "Instruction";
            this.btIns.UseVisualStyleBackColor = false;
            this.btIns.Click += new System.EventHandler(this.BtIns_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.picSan);
            this.Controls.Add(this.btIns);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy San";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSan;
        private System.Windows.Forms.Button btIns;
    }
}