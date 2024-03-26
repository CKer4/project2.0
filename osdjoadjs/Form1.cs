using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string userName1 = Nametxtbox1.Text;
            string userName2 = Nametxtbox2.Text;

            if (!string.IsNullOrEmpty(userName1) && !string.IsNullOrEmpty(userName2))
            {
                string character1 = GetSelectedCharacter(Characterpic1);
                string character2 = GetSelectedCharacter(Characterpic2);

                if (!string.IsNullOrEmpty(character1) && !string.IsNullOrEmpty(character2))
                {
                    string saveData1 = userName1 + " + " + character1;
                    string saveData2 = userName2 + " + " + character2;

                    string savePath = "saveData.txt";

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(savePath))
                        {
                            writer.WriteLine(saveData1);
                            writer.WriteLine(saveData2);
                        }
                        MessageBox.Show("Data saved successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving the data: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Please select a valid character");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid name.");
            }
        }
        private string GetSelectedCharacter(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                string characterName = pictureBox.Name;
                return characterName;
            }
            return null;
        }

        private void Nametxtbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
