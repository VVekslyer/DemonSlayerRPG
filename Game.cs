using System;
using System.Drawing;
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

        void Continue()
        {
            if (BattleWon)
                VictoryScreen();
            else if (Loading && !InBattle)
                Load();
            else if (!InBattle)
                DialogueBox.AdvanceStory();
            //else if (InBattle)


            if (InBattle)
                LoadBattle(CurrentBattle);
        }

        private void screen_Click(object sender, EventArgs e)
        {
            Continue();
        }        
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Continue();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        new void Load()
        {
            //if (CurrentBattle != null)
            //    LoadBattle(CurrentBattle);

            if (CurrentParty.Count == 0)
            {
                PartyMenu.InitiateMC(DialogueBox.PlayerInput.Text);
                DialogueBox.AdvanceStory();
            }
        }

        public void LoadBattle(Battle battle)
        {
            sceneBox.Controls.Add(battle);
            sceneBox.SendToBack();
            sceneBox.Controls[0].BringToFront();
            sceneBox.Controls[0].Location = new Point(-2, -2);
            CurrentBattle.midDemon.BackgroundImage = Properties.Resources.temple_demon;
            InBattle = true;
            PlayerTurn = true;
            Turns = CurrentParty.Count;
            Turn = 0;
            DialogueBox.DisplayText(CurrentDemon.FirstMessage);
        }

        public void VictoryScreen()
        {
            InBattle = false;
            BattleWon = true;
            DialogueBox.DisplayText(" * You are victorious!\n * You've gained 20 EXP.");
        }

    }
}
