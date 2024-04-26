using osdjoadjs.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osdjoadjs
{
    internal class rollingDiceClass
    {
        public static int diceRoll(PictureBox picture)
        {
            //Rolling dice code
            //This randomly generates a number from 1 and 7
            int dice = 0;
            Random random = new Random();
            dice = random.Next(1, 7);

            // This switch statement will add the associated image to dice picturebox but only if the case matches with dice
            switch (dice)
            {
                case 1:
                    picture.Image = Resources._1;
                    break;
                case 2:
                    picture.Image = Resources._2;
                    break;
                case 3:
                    picture.Image = Resources._3;
                    break;
                case 4:
                    picture.Image = Resources._4;
                    break;
                case 5:
                    picture.Image = Resources._5;
                    break;
                case 6:
                    picture.Image = Resources._6;
                    break;
            }
            //This stretches the image to fit inside the picturebox
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            return dice;
        }

        public static int move(ref int x, ref int y, int p, int dice, PictureBox px)
        {
            if (dice + p > 100)
            {
                MessageBox.Show("Need to land exactly on 100 to win");
            }
            else
            {
                for (int i = 0; i < dice; i++)
                {

                    if (p == 10)
                    {
                        x = 615;
                        y = 612;
                    }
                    else if (p == 20)
                    {
                        x = 3;
                        y = 538;
                    }
                    else if (p == 30)
                    {
                        x = 615;
                        y = 466;
                    }
                    else if (p == 40)
                    {
                        x = 3;
                        y = 394;
                    }
                    else if (p == 50)
                    {
                        x = 615;
                        y = 322;
                    }
                    else if (p == 60)
                    {
                        x = 3;
                        y = 250;
                    }
                    else if (p == 70)
                    {
                        x = 615;
                        y = 178;
                    }
                    else if (p == 80)
                    {
                        x = 3;
                        y = 106;
                    }
                    else if (p == 90)
                    {
                        x = 615;
                        y = 34;
                    }
                    else if (p >= 10 && p < 20 || p >= 30 && p < 40 || p >= 50 && p < 60 || p >= 70 && p < 80 || p >= 90)
                    {
                        x -= 68;
                    }
                    else
                    {
                        x += 68;
                    }



                    px.Location = new Point(x, y);
                    p++;

                }
            }
   
            return p;
        }

        public static int snake(ref int x, ref int y, int p, PictureBox px)
        {
            if (p == 29)
            {
                x = 547;
                y = 684;
                p = 9;
                MessageBox.Show("Went down the snake!");
            }
            else if (p == 38)
            {
                x = 343;
                y = 612;
                p = 15;
                MessageBox.Show("Went down the snake!");
            }
            else if (p == 47)
            {
                x = 275;
                y = 684;
                p = 5;
                MessageBox.Show("Went down the snake!");
            }
            else if (p == 53)
            {
                x = 479;
                y = 466;
                p = 33;
                MessageBox.Show("Went down the snake!");
            }
            else if (p == 62)
            {
                x = 207;
                y = 466;
                p = 37;
                MessageBox.Show("Went down the snake!");
            }
            else if (p == 86)
            {
                x = 411;
                y = 322;
                p = 54;
                MessageBox.Show("Went down the snake!");
            }
            else if (p == 92)
            {
                x = 615;
                y = 250;
                p = 70;
                MessageBox.Show("Went down the snake!");
            }
            else if (p == 97)
            {
                x = 275;
                y = 538;
                p = 25;
                MessageBox.Show("Went down the snake!");
            }

            px.Location = new Point(x, y);

            return p;
        }

        public static int ladders(ref int x, ref int y, int p, PictureBox px)
        {
            if (p == 2)
            {
                x = 139;
                y = 538;
                p = 23;
                MessageBox.Show("Went up the ladder!");
            }
            else if (p == 8)
            {
                x = 411;
                y = 466;
                p = 34;
                MessageBox.Show("Went up the ladder!");
            }
            else if (p == 20)
            {
                x = 207;
                y = 178;
                p = 77;
                MessageBox.Show("Went up the ladder!");
            }
            else if (p == 32)
            {
                x = 479;
                y = 250;
                p = 68;
                MessageBox.Show("Went up the ladder!");
            }
            else if (p == 41)
            {
                x = 71;
                y = 178;
                p = 79;
                MessageBox.Show("Went up the ladder!");
            }
            else if (p == 74)
            {
                x = 479;
                y = 106;
                p = 88;
                MessageBox.Show("Went up the ladder!");
            }
            else if (p == 82)
            {
                x = 3;
                y = 34;
                p = 100;
                MessageBox.Show("Went up the ladder!");
            }
            else if (p == 85)
            {
                x = 343;
                y = 34;
                p = 95;
                MessageBox.Show("Went up the ladder!");
            }

            px.Location = new Point(x, y);

            return p;
        }

        public static int jump(ref int x, ref int y, int p, int dice, PictureBox px)
        {
            if (p == 35)
            {
                if (dice == 1)
                {
                    x = 343;
                    y = 394;
                    p = 46;
                    MessageBox.Show("Jumped Up 1");
                }
                else if (dice == 2)
                {
                    x = 343;
                    y = 322;
                    p = 55;
                    MessageBox.Show("Jumped Up 2");
                }
                else if (dice == 3)
                {
                    x = 343;
                    y = 255;
                    p = 66;
                    MessageBox.Show("Jumped Up 3");
                }
                else if (dice == 4)
                {
                    x = 343;
                    y = 178;
                    p = 75;
                    MessageBox.Show("Jumped Up 4");
                }
                else if (dice == 5)
                {
                    x = 343;
                    y = 106;
                    p = 86;
                    MessageBox.Show("Jumped Up 5");
                }
                else if (dice == 6)
                {
                    x = 343;
                    y = 34;
                    p = 95;
                    MessageBox.Show("Jumped Up 6");
                }
            }

            px.Location = new Point(x, y);

            return p;
        }
        public static int moveback(ref int x, ref int y, int p, PictureBox px)
        {
            if (p == 44)
            {
                x = 139;
                y = 394;
                p = 43;
                MessageBox.Show("Moved back a step!");
            }
            px.Location = new Point(x, y);

            return p;
        }
    }
}
