using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {

        int boruhızı = 8;
        int gravity = 10;
        int scoree = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            birdy.Top += gravity;
            pipe1.Left -= boruhızı;
            pipe2.Left -= boruhızı;
            score.Text = "skor : " + scoree;



            if (pipe1.Left < -150)
            {
                pipe1.Left = 816;
                scoree++;
            }

            if (pipe2.Left < -180)
            {
                pipe2.Left = 950;
                scoree++;

            }
            if (birdy.Bounds.IntersectsWith(pipe1.Bounds) ||
                birdy.Bounds.IntersectsWith(pipe2.Bounds) ||
               birdy.Bounds.IntersectsWith(ground.Bounds)||
               birdy.Top < -25
               )
            {
                endGame();
            }

            if (scoree > 2)
            {
                boruhızı = 20;
            }
            

        }

        private void endGame()
        {
            zaman.Stop();
            score.Text += "   Oyun Bitti!";
        }

        private void gameisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {

                if (!zaman.Enabled)
                {
                    restart();
                }
                else
                {
                    gravity = -10;
                }
            }
        }

        private void gameisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        private void restart()
        {
            scoree = 0;
            pipe1.Left = 816;
            pipe2.Left = 950;
            birdy.Top = 100;
            gravity = 10;
            zaman.Start();
            score.Text = "Skor : " + scoree;
            boruhızı = 8;
        }
    }
}
