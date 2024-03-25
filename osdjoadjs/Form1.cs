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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

       

        private void Btnstart_Click(object sender, EventArgs e)
        {
            Form3 gamewindow = new Form3();

            gamewindow.Show();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            string userInput = Nametxtbox.Text;
        }
    }
}
