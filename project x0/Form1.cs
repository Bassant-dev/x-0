using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_x0
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void winner()
        {
            if((button1.Text==button2.Text)&&(button1.Text==button3.Text)&&(button1.Text!=""))
                if (count % 2 == 0)
                {
                    MessageBox.Show("player 1 is the winner");
                        Application.Exit();
                }
                else{
                    MessageBox.Show("player 2 is the winner");
                    Application.Exit();
                }
            if ((button4.Text == button5.Text) && (button4.Text == button6.Text) && (button4.Text != ""))
                if (count % 2 == 0)
                {
                    MessageBox.Show("player 1 is the winner");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("player 2 is the winner");
                    Application.Exit();
                }
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (button7.Text != ""))
                if (count % 2 == 0)
                {
                    MessageBox.Show("player 1 is the winner");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("player 2 is the winner");
                    Application.Exit();
                }
            if ((button3.Text == button6.Text) && (button3.Text == button9.Text) && (button3.Text != ""))
                if (count % 2 == 0)
                {
                    MessageBox.Show("player 1 is the winner");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("player 2 is the winner");
                    Application.Exit();
                }
            if ((button1.Text == button5.Text) && (button3.Text == button9.Text) && (button3.Text != ""))
                if (count % 2 == 0)
                {
                    MessageBox.Show("player 1 is the winner");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("player 2 is the winner");
                    Application.Exit();
                }
            if ((button2.Text == button5.Text) && (button2.Text == button8.Text) && (button2.Text != ""))
                if (count % 2 == 0)
                {
                    MessageBox.Show("player 1 is the winner");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("player 2 is the winner");
                    Application.Exit();
                }
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button1.Text != ""))
                if (count % 2 == 0)
                {
                    MessageBox.Show("player 1 is the winner");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("player 2 is the winner");
                    Application.Exit();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button1.Text = "o";
                winner();
                count++;
            }
            else
            {
                button1.Text = "x";
                winner();
                count++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button2.Text = "o";
                winner();
                count++;
            }
            else
            {
                button2.Text = "x";
                winner();
                count++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button3.Text = "o";
                winner();
                count++;
            }
            else
            {
                button3.Text = "x";
                winner();
                count++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button4.Text = "o";
                winner();
                count++;
            }
            else
            {
                button4.Text = "x";
                winner();
                count++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button5.Text = "o";
                winner();
                count++;
            }
            else
            {
                button5.Text = "x";
                winner();
                count++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button6.Text = "o";
                winner();
                count++;
            }
            else
            {
                button6.Text = "x";
                winner();
                count++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button7.Text = "o";
                winner();
                count++;
            }
            else
            {
                button7.Text = "x";
                winner();
                count++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button8.Text = "o";
                winner();
                count++;
            }
            else
            {
                button8.Text = "x";
                winner();
                count++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button9.Text = "o";
                winner();
                count++;
            }
            else
            {
                button9.Text = "x";
                winner();
                count++;
            }
        }
    }
}
