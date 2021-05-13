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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
       
private void Main_Load(object sender, EventArgs e)
        {

            Rectangle r = new Rectangle(0, 0, picSan.Width, picSan.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, picSan.Width, picSan.Height);
            Region rg = new Region(gp);
            picSan.Region = rg;

        }

        private void BtPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Demo form2 = new Demo();
            form2.ShowDialog();
            this.Close();
        }

        private void BtIns_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instruction form3 = new Instruction();
            form3.ShowDialog();
            this.Close();
        }
    }
}
