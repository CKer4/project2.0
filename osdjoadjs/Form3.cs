﻿using osdjoadjs.Properties;
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
        int currentPlayer = 1;
        int x = 3, y = 684, diceNum, p = 0, counter;
        int ax = 3, ay = 684, ap = 0;
        bool skipturn = false;

        private void button3_Click(object sender, EventArgs e)
        {
            currentPlayer = 1;
            btnRoll.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentPlayer = 2;
            btnRoll.Enabled = true;
        }

        public Form3()
        {
            InitializeComponent();
        }



        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Restartbtn_Click_1(object sender, EventArgs e)
        {
            pictureBox8.Location = new Point(3, 684);
            pictureBox10.Location = new Point(3, 684);

            p = 0;
            p++;
            ap = 0;
            ap++;

            x = 3;
            y = 684;
            ax = 3;
            ay = 684;

            diceNum = 0;
            counter = 0;

            label8.Text = "0";
            label10.Text = "0";

            currentPlayer = 1;
            button3.BackColor = System.Drawing.Color.Green;
            button4.BackColor = DefaultBackColor;
            btnRoll.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please click on Player 1 button when moving to the board page to engage your role");
            button3.BackColor = System.Drawing.Color.Green;
            btnRoll.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            pictureBox8.Visible = true;
            pictureBox8.Location = new Point(x, y);
            p++;
            pictureBox10.Visible = true;
            pictureBox10.Location = new Point(x, y);
            ap++;
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //This is code for player 1
            // This is for skipping a turn.
            if (currentPlayer == 1)
            {
                if (p == 94 && counter == 0)
                {
                    MessageBox.Show("Skip a turn");
                    skipturn = true;
                    counter++;
                }
                else
                {
                    skipturn = false;
                }
                // The methods from rollingDiceClass.cs are called here
                if (skipturn == false)
                {
                    diceNum = rollingDiceClass.diceRoll(pictureBox3);

                    p = rollingDiceClass.move(ref x, ref y, p, diceNum, pictureBox8);

                    p = rollingDiceClass.jump(ref x, ref y, p, diceNum, pictureBox8);

                    p = rollingDiceClass.moveback(ref x, ref y, p, pictureBox8);

                    p = rollingDiceClass.ladders(ref x, ref y, p, pictureBox8);

                    if (p == 100)
                    {
                        Form2 gamewindow = new Form2();
                        gamewindow.Show();
                        btnRoll.Enabled = false;
                    }

                    p = rollingDiceClass.snake(ref x, ref y, p, pictureBox8);
                }

                label8.Text = p.ToString();
                btnRoll.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
                button3.BackColor = DefaultBackColor;
                button4.BackColor = System.Drawing.Color.Green;
            }
            else if (currentPlayer == 2)
            {
                //This is code for player 2
                // This is for skipping a turn.
                if (ap == 94 && counter == 0)
                {
                    MessageBox.Show("Skip a turn");
                    skipturn = true;
                    counter++;
                }
                else
                {
                    skipturn = false;
                }
                // The methods from rollingDiceClass.cs are called here
                if (skipturn == false)
                {
                    diceNum = rollingDiceClass.diceRoll(pictureBox3);

                    ap = rollingDiceClass.move(ref ax, ref ay, ap, diceNum, pictureBox10);

                    ap = rollingDiceClass.jump(ref ax, ref ay, ap, diceNum, pictureBox10);

                    ap = rollingDiceClass.moveback(ref ax, ref ay, ap, pictureBox10);

                    ap = rollingDiceClass.ladders(ref ax, ref ay, ap, pictureBox10);

                    if (ap == 100)
                    {
                        Form2 gamewindow = new Form2();
                        gamewindow.Show();
                        btnRoll.Enabled = false;
                    }

                    ap = rollingDiceClass.snake(ref ax, ref ay, ap, pictureBox10);
                }
                label10.Text = ap.ToString();
                btnRoll.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = false;
                button4.BackColor = DefaultBackColor;
                button3.BackColor = System.Drawing.Color.Green;
            }

        }

        public void SetPlayerNames(string player1Name, string player2Name)
        {
            label2.Text = player1Name;
            Playername1.Text = player2Name;
        }
    }
}


