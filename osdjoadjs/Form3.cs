using osdjoadjs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osdjoadjs
{
    public partial class Form3 : Form
    {
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

        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //Rolling dice code
            //This randomly generates a number from 1 and 7
            int dice = 0;
            Random random = new Random();
            dice = random.Next(1, 7);

            // This switch statement will add the associated image to dice picturebox but only if they match
            switch (dice)
            {
                case 1:
                    pictureBox3.Image = Resources._1;
                    break;
                case 2:
                    pictureBox3.Image = Resources._2;
                    break;
                case 3:
                    pictureBox3.Image = Resources._3;
                    break;
                case 4:
                    pictureBox3.Image = Resources._4;
                    break;
                case 5:
                    pictureBox3.Image = Resources._5;
                    break;
                case 6:
                    pictureBox3.Image = Resources._6;
                    break;
            }
            //This stretches the image to fit inside the picturebox
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
