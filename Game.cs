using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DemonSlayerRPG.Globals;
using DemonSlayerRPG.components.enemies;

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
            if (CreatingMC)
            {
                PartyMenu.InitiateMC(DialogueBox.PlayerInput.Text);
                DialogueBox.AdvanceStory();
            }
            else
                DialogueBox.AdvanceStory();
        }        
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && CreatingMC)
            {
                PartyMenu.InitiateMC(DialogueBox.PlayerInput.Text);
                DialogueBox.AdvanceStory();
                return true;
            }

            else if (keyData == Keys.Enter)
            {
                PartyMenu.Focus();
                DialogueBox.AdvanceStory();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public static void LoadBattle(Battle battle)
        {

        }

    }
}
