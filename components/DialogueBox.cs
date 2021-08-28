using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using static DemonSlayerRPG.Globals;

namespace DemonSlayerRPG.components
{
    public partial class DialogueBox : Panel
    {
        // This component reads the text file containing the story,
        // displays it to the user, and also prompts the user
        // to type their name and displays it to them.

        RichTextBox Dialogue = new RichTextBox()
        {
            BackColor = Color.FromArgb((int)(byte)14, (int)(byte)16, (int)(byte)21),
            Font = new Font("ProggyCleanTT", 27.75F, FontStyle.Regular, GraphicsUnit.Point),
            ForeColor = Color.WhiteSmoke,
            ImeMode = ImeMode.Off,
            Visible = true,
            Name = "Dialogue",
            Size = new Size(640, 101),
            ReadOnly = true,
            TabIndex = 2,
            Text = ""
        };
        Panel PlayerPanel = new Panel()
        {
            BackColor = Color.FromArgb((int)(byte)14, (int)(byte)16, (int)(byte)29),
            Visible = false,
            BorderStyle = BorderStyle.Fixed3D,
            Name = "PlayerPanel",
            Size = new Size(640, 34),
            Dock = DockStyle.Bottom,
            TabIndex = 1,
            
        };
        TextBox PlayerInput = new TextBox()
        {
            BackColor = Color.FromArgb((int)(byte)14, (int)(byte)16, (int)(byte)29),
            BorderStyle = BorderStyle.None,
            Font = new Font("ProggyCleanTT", 27.75F, FontStyle.Regular, GraphicsUnit.Point),
            ForeColor = Color.WhiteSmoke,
            Location = new Point(54, 0),
            MaxLength = 20,
            Name = "playerText",
            Size = new Size(659, 31),
            TabIndex = 3,
        };
        Button SubmitButton = new Button()
        {
            BackColor = Color.FromArgb((int)(byte)14, (int)(byte)16, (int)(byte)29),
            FlatStyle = FlatStyle.Flat,
            Font = new Font("ProggyCleanTT", 27.75F, FontStyle.Regular, GraphicsUnit.Point),
            ForeColor = SystemColors.ButtonHighlight,
            Dock = DockStyle.None,
            Name = "SubmitButton",
            Location = new Point(11, -4),
            Size = new Size(27, 42),
            TabIndex = 4,
            Text = ">",
            TextAlign = ContentAlignment.TopCenter,
            UseVisualStyleBackColor = false,
        };
        public DialogueBox()
        {
            Font = new Font("ProggyCleanTT", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BorderStyle = BorderStyle.None;
            ForeColor = Color.WhiteSmoke;
            ImeMode = ImeMode.Off;
            Location = new Point(311, 468);
            Name = "DialogueBox";
            Size = new Size(640, 101);
            TabIndex = 1;
            Text = "";


            SubmitButton.FlatAppearance.BorderColor = Color.FromArgb((int)(byte)14, (int)(byte)16, (int)(byte)21);
            PlayerPanel.Controls.Add(PlayerInput);
            PlayerPanel.Controls.Add(SubmitButton);
            Controls.Add(Dialogue);
            Controls.Add(PlayerPanel);
            InitializeComponent();
        }

        int i = 1;
        const string path = @"C:\Users\vital\source\repos\DemonSlayerRPG\bin\Debug\netcoreapp3.1\story\test-story.txt";
        string PlayerName;
        string[] textFile = File.ReadAllLines(path);  
        string ch;




        public void AdvanceStory()
        {
            // if the line contains a "#", it will skip that line.
            // if the line contains a ">", it prompt the player to write something.
            // if the line contains a "@", it will activate a specified command.

            ch = textFile[i];

            while (true)
            {
                if (PlayerPanel.Visible)
                {
                    PlayerName = PlayerInput.Text;
                    CurrentParty.Add(new PartyMember(Name: PlayerName, BreathStyle: "Water", MaxHP: 30, MaxSP: 20, Strength: 3, Focus: 3, Kindness: 3));
                }

                if (ch[1] == '>')
                {
                    PlayerPanel.Visible = true;
                    PlayerPanel.BringToFront();
                    PlayerInput.Focus();
                    ch = textFile[++i];
                    break;
                }

                if (ch[1] == '@')
                {
                    Command();
                    break;
                }

                if (ch[1] == '#')
                {
                    Dialogue.Clear();
                    ch = textFile[++i];
                    Dialogue.AppendText($"{ch + '\n'}");
                    ch = textFile[++i];

                    while (ch[1] != '*' && ch[1] != '#' && ch[1] != '>')
                    {
                        Dialogue.AppendText($"{ch + '\n'}");
                        ch = textFile[++i];
                    }

                    break;
                }

                if (ch[1] == '*')
                {
                    Dialogue.AppendText($"{ch + '\n'}");
                    ch = textFile[++i];

                    while (ch[1] != '*' && ch[1] != '#' && ch[1] != '>')
                    {
                        Dialogue.AppendText($"{ch + '\n'}");
                        ch = textFile[++i];
                    }

                    break;
                }

                PlayerInput.Clear();
            }



            void Command()
            {
                if (ch[2] == 'P' && ch[3] == 'N')       // @PN command displays the player's name.
                {
                    Dialogue.Clear();
                    ch = textFile[++i];
                    Dialogue.AppendText(string.Format(ch + '\n', PlayerName));
                    ch = textFile[++i];
                }

                else if (ch[2] == 'B' && ch[3] == '1')  // @B1 command starts the first battle.
                {

                }

                else if (ch[2] == 'D' && ch[3] == '1')  // @D1 command starts the first dungeon.
                {
                    Dialogue.Clear();

                }



            }

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
