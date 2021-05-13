using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Game_Flappy_San
{
    public partial class Demo : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        
        SoundPlayer lose = new SoundPlayer();
        public Demo()
        {
            InitializeComponent();

            player.URL = "Sounds_San.wav";
            lose.SoundLocation = "Sounds_Lose.wav";
        }

        #region Bien
        int y_picTreeTop1;
        int y_picTreeBot1;
        int y_picTreeTop2;
        int y_picTreeBot2;

        int x_DoubleTree1, x_DoubleTree2;

        int r_2tree = 200; //Khoảng cách giữa cây trên & cây dưới

        int score = 0;

        int fly = 0;

        bool endGame = false; 
        #endregion


        private void NewGame()
        {
            score = 0;
            if (pS % 2 == 0)
                player.controls.play();
            timer1.Interval = 25;
            timer2.Interval = 50;


            picOver.Size = new Size(10, 10);
            picOver.Location = new Point(0, 490);

            picSan.Location = new Point(2, 215);
            Rectangle r = new Rectangle(0, 0, picSan.Width, picSan.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, picSan.Width, picSan.Height);
            Region rg = new Region(gp);
            picSan.Region = rg;


            

            //Cây 1
            x_DoubleTree1 = this.Width + 215;
            // ..Cây đi từ ngoài chiều rộng form + 215 vào 

            //Cây trên 1
            y_picTreeTop1 = -250; //Phần cây trên hiện lên màn hình là 150 <=> (400 - 250)
            picTreeTop1.Location = new Point(x_DoubleTree1, y_picTreeTop1);

            //Cây dưới 1
            y_picTreeBot1 = (picTreeTop1.Height + y_picTreeTop1) + r_2tree;
            // ..Phàn cây dưới hiện trên màn hình là 150
            // ..[chiều dài form]500 - [chiều dài cây trên hiện lên màn hình]150 - [r_2tree]200
            picTreeBot1.Location = new Point(x_DoubleTree1, y_picTreeBot1);

            //Cây 2
            x_DoubleTree2 = x_DoubleTree1 + picTreeTop1.Width + 205; //Mỗi cây trên cách nhau 205

            //Cây trên 2
            y_picTreeTop2 = -230; //170
            picTreeTop2.Location = new Point(x_DoubleTree2, y_picTreeTop2);

            //Cây dưới 2
            y_picTreeBot2 = (picTreeTop2.Height + y_picTreeTop2) + r_2tree;
            // >> tương tự cây 1
            picTreeBot2.Location = new Point(x_DoubleTree2, y_picTreeBot2);

            lbScore.Text = "Score: 0";

        }
        private void ReStart()
        {
            endGame = false;
            lose.Stop();
            timer1.Stop();
            timer2.Stop();
        }

        void EndGame()
        {
            player.controls.stop();

            timer1.Stop();
            
            picOver.Size = new Size(300, 100);
            picOver.Location = new Point(100, 200);

            endGame = true;
        }
        
        private void OnSound()
        {

            if (endGame == false)
            {
                player.controls.play(); 
            }
            picSound.Image = Image.FromFile(Application.StartupPath + @"\Image\mute.png");
        }
        private void PauseSound()
        {
            
            player.controls.pause();
            lose.Stop();
            picSound.Image = Image.FromFile(Application.StartupPath + @"\Image\mute_off.png");
        }

        private void Demo_Load(object sender, EventArgs e)
        {
            NewGame();
            player.controls.play();
        }


        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close Flappy San?", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }


        int pS = 0;
        private void picSound_Click(object sender, EventArgs e)
        {
            pS++;
            if (pS % 2 != 0)
            {
                PauseSound();
            }

            else
            {
                OnSound();
            }
        }


        private void picReStart_Click(object sender, EventArgs e)
        {
            ReStart();
            player.controls.stop();
            NewGame();
        }


        private void Demo_KeyDown(object sender, KeyEventArgs e)
        {
            if (endGame == false)
            {
                if (e.KeyCode == Keys.Space)
                {
                    timer1.Start();
                    timer2.Start();
                    fly = -10;
                }
            }
        }


        private void Demo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                fly = 10;
        }


        private void Demo_MouseDown(object sender, MouseEventArgs e)
        {if (endGame == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    timer1.Start();
                    timer2.Start();
                    fly = -10;
                }
            }
        }
        

        private void Demo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                fly = 10;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.M:
                    PauseSound(); pS = 1;
                    return true;
                case Keys.N:
                    OnSound();
                    pS = 2;
                    return true;
                case Keys.Enter:
                    ReStart();
                    player.controls.stop();
                    NewGame(); 
                    return true;

            }
            return base.ProcessDialogKey(keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // DoubleBuffer => hiệu chỉnh giảm giựt màn hình.
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);

            x_DoubleTree1 -= 5;
            x_DoubleTree2 -= 5;

            picTreeTop1.Location = new Point(x_DoubleTree1, y_picTreeTop1);
            picTreeBot1.Location = new Point(x_DoubleTree1, y_picTreeBot1);

            picTreeTop2.Location = new Point(x_DoubleTree2, y_picTreeTop2);
            picTreeBot2.Location = new Point(x_DoubleTree2, y_picTreeBot2);

            //Hiện lại
            if (x_DoubleTree1 + picTreeTop1.Width <= 0)
            {
                score++;
               
                x_DoubleTree1 = 205 + picTreeTop2.Width + 205;

                Random r = new Random();
                y_picTreeTop1 = r.Next(-325, -175);
                y_picTreeBot1 = (picTreeTop1.Height + y_picTreeTop1) + r_2tree;

                picTreeTop1.Location = new Point(x_DoubleTree1, y_picTreeTop1);
                picTreeBot1.Location = new Point(x_DoubleTree1, y_picTreeBot1);
            }

            if (x_DoubleTree2 + picTreeTop2.Width <= 0)
            {
                score++;
               
                x_DoubleTree2 = 205 + picTreeTop1.Width + 205;

                Random r = new Random();
                y_picTreeTop2 = r.Next(-325, -175);
                y_picTreeBot2 = (picTreeTop2.Height + y_picTreeTop2) + r_2tree;

                picTreeTop2.Location = new Point(x_DoubleTree2, y_picTreeTop2);
                picTreeBot2.Location = new Point(x_DoubleTree2, y_picTreeBot2);
            }


            if (score > 4)
                timer1.Interval = 20;
            if (score > 9)
                timer1.Interval = 15;
            if (score > 14)
                timer1.Interval = 10;
            if (score > 19)
                timer1.Interval = 5;
            if (score > 24)
                timer1.Interval = 1;


            lbScore.Text = "Score: " + score.ToString();
            

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            EndGame();
            timer2.Stop();
            lose.Stop();
            this.Hide();
            Main form3 = new Main();
            form3.ShowDialog();
            this.Close();
            //Nút trở về màn hình Main
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // DoubleBuffer => hiệu chỉnh không bị giảm màn hình.
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);

            picSan.Top -= fly; //Di chuyển lên --> đổi fly lên/xuống theo nhấn/nhả phím cách hay chuột
            if (picSan.Top > 0)
            {
                if (score > 4)
                    timer2.Interval = 40;
                if (score > 9)
                    timer2.Interval = 30;
                if (score > 14)
                    timer2.Interval = 20;
                if (score > 19)
                    timer2.Interval = 10;
                if (score > 24)
                    timer2.Interval = 1;



                //if (picSan.Right >= picTreeTop1.Left && picSan.Right <= picTreeTop1.Right)
                //    if (picSan.Top <= picTreeTop1.Bottom || picSan.Bottom >= picTreeBot1.Top)
                //        EndGame();
                //if (picSan.Right >= picTreeTop2.Left && picSan.Right <= picTreeTop2.Right)
                //    if (picSan.Top <= picTreeTop2.Bottom || picSan.Bottom >= picTreeBot2.Top)
                //        EndGame();
                //if (picSan.Top >= this.Height)
                //    EndGame();

                //a.Bounds.IntersetsWith(b.Bounds) >> Va chạm giữa 2 picturebox

                if (picSan.Bounds.IntersectsWith(picTreeTop1.Bounds) ||
                picSan.Bounds.IntersectsWith(picTreeTop2.Bounds) ||
                picSan.Bounds.IntersectsWith(picTreeBot1.Bounds) ||
                picSan.Bounds.IntersectsWith(picTreeBot2.Bounds) ||
                picSan.Bottom >= this.Height)
                    EndGame();
            }

            else
            {
                EndGame();
                if (pS % 2 == 0)
                    lose.Play();
                timer2.Stop();
            }
        }

    }
}
