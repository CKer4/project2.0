using osdjoadjs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osdjoadjs
{
    public partial class Form3 : Form
    {
        bool play1 = false;
        int x = 3, y = 684, diceNum, p = 0;
        int[] pos = new int[100];
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            ladderinitialization();
            snakebiteinitialization();
            pictureBox8.Visible = false;

        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (play1 == true)
            {
                rollingDiceClass.move(ref x, ref y, ref p, diceNum, ref pos, pictureBox8);
                /*x += 68;
                pictureBox8.Location = new Point(x, y);
                */
            }

            diceNum = rollingDiceClass.diceRoll(pictureBox3);
            if (play1 == false)
            {
                pictureBox8.Visible = true;
                pictureBox1.Visible = false;
                play1 = true;
                pictureBox8.Location = new Point(x, y);
            }

        }

        private void snakebiteinitialization()
        {
            pos[29] = 9;
            pos[38] = 15;
            pos[47] = 5;
            pos[53] = 33;
            pos[62] = 37;
            pos[86] = 54;
            pos[92] = 70;
            pos[97] = 25;
        }

        private void ladderinitialization()
        {
            pos[2] = 23;
            pos[8] = 34;
            pos[20] = 77;
            pos[32] = 68;
            pos[41] = 79;
            pos[74] = 88;
            pos[82] = 100;
            pos[85] = 95;
        }

    }
}
