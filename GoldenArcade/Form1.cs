using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace GoldenArcade
{
    public partial class GoldenArcade : Form
    {
        public GoldenArcade()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerLabel.Hide();
            goLabel.Hide();
        }
        private void effectButton_Click(object sender, EventArgs e)

        {

            var war = new System.Windows.Media.MediaPlayer();
            war.Open(new Uri(Application.StartupPath + "/Resources/blip.wav"));
            war.Play();
        }

            private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Hide();
            timerLabel.Show();

            Refresh();
            Thread.Sleep(1000);
            timerLabel.Text = "Game will start in: 2";

            Refresh();
            Thread.Sleep(1000);
            timerLabel.Text = "Game will start in: 1";

            Refresh();
            Thread.Sleep(1000);
            timerLabel.Hide();

            this.BackColor = Color.Green;
            goLabel.Show();
        }

        private void goLabel_Click(object sender, EventArgs e)
        {

        }
    }

}