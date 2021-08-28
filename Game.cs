using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemonSlayerRPG
{
    partial class Game : Form
    {
        public Game()
        {
            var music = new WMPLib.WindowsMediaPlayer();
            //music.URL = @"music\Opening Theme.mp3";
            InitializeComponent();
        }

        private void screen_Click(object sender, EventArgs e)
        {
            DialogueBox.AdvanceStory();
        }        
        
        
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                DialogueBox.AdvanceStory();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void DialogueBox_Click(object sender, EventArgs e)
        {
            DialogueBox.AdvanceStory();
        }
    }
}
