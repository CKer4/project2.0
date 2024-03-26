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
            pictureBox3.Image = Image.FromFile(@"C:\Users\Work\Source\Repos\project2.0\osdjoadjs\Resources\Roll the dice1.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            int dice = 0;
            Random random = new Random();
            dice = random.Next(1,6);

            pictureBox3.Image = Image.FromFile(@"C:\Users\Work\Source\Repos\project2.0\osdjoadjs\Resources\"+dice+".png");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }


    }
}
