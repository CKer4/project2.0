using osdjoadjs.Properties;
using System;
using System.Collections.Generic;
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

        public static void move(ref int x, ref int y, ref int p, int dice, ref int[] pos, PictureBox px)
        {
            if ( p == 9 ) 
            {
                x = 615;
                y = 612;
            }
            else if (p == 19)
            {
                x = 3;
                y = 538;
            }
            else if (p == 29)
            {
                x = 615;
                y = 466;
            }
            else if (p == 39)
            {
                x = 3;
                y = 394;
            }
            else if (p == 49)
            {
                x = 615;
                y = 322;
            }
            else if (p == 59)
            {
                x = 3;
                y = 250;
            }
            else if (p == 69)
            {
                x = 615;
                y = 178;
            }
            else if (p == 79)
            {
                x = 3;
                y = 106;
            }
            else if (p == 89)
            {
                x = 615;
                y = 34;
            }

            else if (p >= 10 && p < 19 || p >= 30 && p < 39 || p >= 50 && p < 59|| p >= 70 && p < 79 || p >= 90)
            {
                x -= 68;
            }
            else
            {
                x += 68;
            }

            if (p == 19)
            {
                x = 3;
                y = 538;
            }



            px.Location = new Point(x, y);
            p++;
            pos[p] = 1; 
        }
    }
}
