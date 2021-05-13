using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Flappy_San
{
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main form1 = new Main();
            form1.ShowDialog();
            this.Close();
        }

        private void Instruction_Load(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;


            Rectangle d = new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height);
            System.Drawing.Drawing2D.GraphicsPath gd = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            Region rd = new Region(gp);
            pictureBox2.Region = rg;

        }
    }
}
