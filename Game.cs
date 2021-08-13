using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

// TODO - [x] Allow the player to input their name.
// TODO - [x] Display playerName in the text file.
// TODO - [>] Create a hotkey for "Enter" that will advance the story and submit user input.
// TODO - [ ] Add animations to the sceneBox. Such as fade in, brief GIFs.
// TODO - [ ] Add animation to the text display. Make it so each character is displayed one by one.
// TODO - [x] Add a hotkey; likely an enter key to progress the dialog.
// TODO - [ ] Create a save file.

namespace DemonSlayerRPG
{
    public partial class Game : Form
    {
        static int l = 2;
        const string path = @"story\test-story.txt";
        string[] textFile = File.ReadAllLines(path);
        public static string playerInput;
        public static string playerName;
        

        public Game()
        {
            //var music = new WMPLib.WindowsMediaPlayer();
            //music.URL = @"music\Opening Theme.mp3";
            InitializeComponent();
        }

        private void screen_Click(object sender, EventArgs e)
        {
            // Everytime the player clicks the main screen,
            // the next line of the story text file will be read.

            AdvanceStory();

        }


        private void AdvanceStory()
        {
            // if the line contains a "#", it will skip that line.
            // if the line contains a ">", it prompt the player to write something.
            // if the line contains a "@", it will activate a specified command.


            string line;
            line = textFile[l];
            bool displayingPassage = true;

            while (displayingPassage)
            {
                if (playerTextbox.Visible)
                {
                    playerTextbox.Visible = false;
                    playerName = playerText.Text;
                    mcName.Text = playerName;
                    mcName.ForeColor = System.Drawing.Color.WhiteSmoke;
                    //var pd = @"data\player-data.txt";
                    //FileStream playerData = new FileStream(pd, FileAccess.Write);
                }

                if (line[1] == '>')
                {
                    playerTextbox.Visible = true;
                    playerText.Focus();
                    line = textFile[++l];
                    break;
                }

                if (line[1] == '@')
                {
                    textBox.Clear();
                    line = textFile[++l];
                    textBox.AppendText(string.Format(line + '\n', playerName));
                    line = textFile[++l];
                    break;
                }

                if (line[1] == '#')
                {
                    textBox.Clear();
                    line = textFile[++l];
                    textBox.AppendText($"{line + '\n'}");
                    line = textFile[++l];

                    while (line[1] != '*' && line[1] != '#' && line[1] != '>')
                    {
                        textBox.AppendText($"{line + '\n'}");
                        line = textFile[++l];
                    }

                    break;
                }

                if (line[1] == '*')
                {
                    textBox.AppendText($"{line + '\n'}");
                    line = textFile[++l];

                    while (line[1] != '*' && line[1] != '#' && line[1] != '>')
                    {
                        textBox.AppendText($"{line + '\n'}");
                        line = textFile[++l];
                    }

                    break;
                }
            }
        }

        
        // Enter shortcut to advance the story.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                AdvanceStory();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
