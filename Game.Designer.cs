
namespace DemonSlayerRPG
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screen = new System.Windows.Forms.Panel();
            this.playerTextbox = new System.Windows.Forms.Panel();
            this.submitButton = new System.Windows.Forms.Button();
            this.playerText = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.partyButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.skillsButton = new System.Windows.Forms.Button();
            this.defendButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.pm4Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.pm3Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.pm2Name = new System.Windows.Forms.Label();
            this.SPLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.HPLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pm1HP = new System.Windows.Forms.ProgressBar();
            this.mcName = new System.Windows.Forms.Label();
            this.sceneBox = new System.Windows.Forms.Panel();
            this.screen.SuspendLayout();
            this.playerTextbox.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(21)))));
            this.screen.Controls.Add(this.sceneBox);
            this.screen.Controls.Add(this.playerTextbox);
            this.screen.Controls.Add(this.textBox);
            this.screen.Controls.Add(this.panelMenu);
            this.screen.Location = new System.Drawing.Point(53, 50);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1037, 665);
            this.screen.TabIndex = 0;
            this.screen.Click += new System.EventHandler(this.screen_Click);
            // 
            // playerTextbox
            // 
            this.playerTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.playerTextbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerTextbox.Controls.Add(this.submitButton);
            this.playerTextbox.Controls.Add(this.playerText);
            this.playerTextbox.Location = new System.Drawing.Point(311, 533);
            this.playerTextbox.Name = "playerTextbox";
            this.playerTextbox.Size = new System.Drawing.Size(640, 36);
            this.playerTextbox.TabIndex = 5;
            this.playerTextbox.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(21)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("ProggyCleanTT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitButton.Location = new System.Drawing.Point(11, -6);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(27, 42);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = ">";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // playerText
            // 
            this.playerText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.playerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerText.Font = new System.Drawing.Font("ProggyCleanTT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.playerText.Location = new System.Drawing.Point(54, 0);
            this.playerText.MaxLength = 20;
            this.playerText.Name = "playerText";
            this.playerText.Size = new System.Drawing.Size(659, 31);
            this.playerText.TabIndex = 3;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(21)))));
            this.textBox.Font = new System.Drawing.Font("ProggyCleanTT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox.Location = new System.Drawing.Point(311, 468);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBox.Size = new System.Drawing.Size(640, 101);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.panelMenu.Controls.Add(this.partyButton);
            this.panelMenu.Controls.Add(this.itemsButton);
            this.panelMenu.Controls.Add(this.skillsButton);
            this.panelMenu.Controls.Add(this.defendButton);
            this.panelMenu.Controls.Add(this.attackButton);
            this.panelMenu.Controls.Add(this.label8);
            this.panelMenu.Controls.Add(this.pictureBox7);
            this.panelMenu.Controls.Add(this.progressBar6);
            this.panelMenu.Controls.Add(this.label9);
            this.panelMenu.Controls.Add(this.pictureBox8);
            this.panelMenu.Controls.Add(this.progressBar7);
            this.panelMenu.Controls.Add(this.pm4Name);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.pictureBox5);
            this.panelMenu.Controls.Add(this.progressBar4);
            this.panelMenu.Controls.Add(this.label6);
            this.panelMenu.Controls.Add(this.pictureBox6);
            this.panelMenu.Controls.Add(this.progressBar5);
            this.panelMenu.Controls.Add(this.pm3Name);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.progressBar2);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.pictureBox4);
            this.panelMenu.Controls.Add(this.progressBar3);
            this.panelMenu.Controls.Add(this.pm2Name);
            this.panelMenu.Controls.Add(this.SPLabel);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.progressBar1);
            this.panelMenu.Controls.Add(this.HPLabel);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.pm1HP);
            this.panelMenu.Controls.Add(this.mcName);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(197, 665);
            this.panelMenu.TabIndex = 0;
            // 
            // partyButton
            // 
            this.partyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partyButton.Font = new System.Drawing.Font("ProggyCleanTT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partyButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.partyButton.Image = global::DemonSlayerRPG.Properties.Resources.people2;
            this.partyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.partyButton.Location = new System.Drawing.Point(23, 508);
            this.partyButton.Name = "partyButton";
            this.partyButton.Size = new System.Drawing.Size(144, 26);
            this.partyButton.TabIndex = 32;
            this.partyButton.Text = "Party";
            this.partyButton.UseVisualStyleBackColor = true;
            // 
            // itemsButton
            // 
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Font = new System.Drawing.Font("ProggyCleanTT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemsButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.itemsButton.Image = global::DemonSlayerRPG.Properties.Resources.bag1;
            this.itemsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemsButton.Location = new System.Drawing.Point(23, 476);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(144, 26);
            this.itemsButton.TabIndex = 31;
            this.itemsButton.Text = "Items";
            this.itemsButton.UseVisualStyleBackColor = true;
            // 
            // skillsButton
            // 
            this.skillsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skillsButton.Font = new System.Drawing.Font("ProggyCleanTT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skillsButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.skillsButton.Image = global::DemonSlayerRPG.Properties.Resources.spark;
            this.skillsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skillsButton.Location = new System.Drawing.Point(23, 444);
            this.skillsButton.Name = "skillsButton";
            this.skillsButton.Size = new System.Drawing.Size(144, 26);
            this.skillsButton.TabIndex = 30;
            this.skillsButton.Text = "Skills";
            this.skillsButton.UseVisualStyleBackColor = true;
            // 
            // defendButton
            // 
            this.defendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defendButton.Font = new System.Drawing.Font("ProggyCleanTT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.defendButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.defendButton.Image = global::DemonSlayerRPG.Properties.Resources.shield3;
            this.defendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.defendButton.Location = new System.Drawing.Point(23, 412);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(144, 26);
            this.defendButton.TabIndex = 29;
            this.defendButton.Text = "Defend";
            this.defendButton.UseVisualStyleBackColor = true;
            // 
            // attackButton
            // 
            this.attackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackButton.Font = new System.Drawing.Font("ProggyCleanTT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attackButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.attackButton.Image = global::DemonSlayerRPG.Properties.Resources.knife1;
            this.attackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attackButton.Location = new System.Drawing.Point(23, 380);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(144, 26);
            this.attackButton.TabIndex = 28;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(38, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "SP";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DemonSlayerRPG.Properties.Resources.lightning;
            this.pictureBox7.Location = new System.Drawing.Point(23, 295);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(19, 10);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            // 
            // progressBar6
            // 
            this.progressBar6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar6.Location = new System.Drawing.Point(67, 297);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(100, 6);
            this.progressBar6.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(38, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "HP";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DemonSlayerRPG.Properties.Resources.heart2;
            this.pictureBox8.Location = new System.Drawing.Point(23, 279);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(19, 10);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            // 
            // progressBar7
            // 
            this.progressBar7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar7.Location = new System.Drawing.Point(67, 277);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(100, 14);
            this.progressBar7.TabIndex = 22;
            // 
            // pm4Name
            // 
            this.pm4Name.AutoSize = true;
            this.pm4Name.ForeColor = System.Drawing.Color.Silver;
            this.pm4Name.Location = new System.Drawing.Point(23, 252);
            this.pm4Name.Name = "pm4Name";
            this.pm4Name.Size = new System.Drawing.Size(64, 20);
            this.pm4Name.TabIndex = 21;
            this.pm4Name.Text = "empty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(38, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "SP";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DemonSlayerRPG.Properties.Resources.lightning;
            this.pictureBox5.Location = new System.Drawing.Point(23, 222);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 10);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // progressBar4
            // 
            this.progressBar4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar4.Location = new System.Drawing.Point(67, 224);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(100, 6);
            this.progressBar4.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(38, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "HP";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DemonSlayerRPG.Properties.Resources.heart2;
            this.pictureBox6.Location = new System.Drawing.Point(23, 206);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 10);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // progressBar5
            // 
            this.progressBar5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar5.Location = new System.Drawing.Point(67, 204);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(100, 14);
            this.progressBar5.TabIndex = 15;
            // 
            // pm3Name
            // 
            this.pm3Name.AutoSize = true;
            this.pm3Name.ForeColor = System.Drawing.Color.Silver;
            this.pm3Name.Location = new System.Drawing.Point(23, 179);
            this.pm3Name.Name = "pm3Name";
            this.pm3Name.Size = new System.Drawing.Size(64, 20);
            this.pm3Name.TabIndex = 14;
            this.pm3Name.Text = "empty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(38, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "SP";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DemonSlayerRPG.Properties.Resources.lightning;
            this.pictureBox3.Location = new System.Drawing.Point(23, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar2.Location = new System.Drawing.Point(67, 151);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 6);
            this.progressBar2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(38, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "HP";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DemonSlayerRPG.Properties.Resources.heart2;
            this.pictureBox4.Location = new System.Drawing.Point(23, 133);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar3.Location = new System.Drawing.Point(67, 131);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 14);
            this.progressBar3.TabIndex = 8;
            // 
            // pm2Name
            // 
            this.pm2Name.AutoSize = true;
            this.pm2Name.ForeColor = System.Drawing.Color.Silver;
            this.pm2Name.Location = new System.Drawing.Point(23, 106);
            this.pm2Name.Name = "pm2Name";
            this.pm2Name.Size = new System.Drawing.Size(64, 20);
            this.pm2Name.TabIndex = 7;
            this.pm2Name.Text = "empty";
            // 
            // SPLabel
            // 
            this.SPLabel.AutoSize = true;
            this.SPLabel.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SPLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SPLabel.Location = new System.Drawing.Point(38, 72);
            this.SPLabel.Name = "SPLabel";
            this.SPLabel.Size = new System.Drawing.Size(23, 16);
            this.SPLabel.TabIndex = 6;
            this.SPLabel.Text = "SP";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DemonSlayerRPG.Properties.Resources.lightning;
            this.pictureBox2.Location = new System.Drawing.Point(23, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar1.Location = new System.Drawing.Point(67, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 6);
            this.progressBar1.TabIndex = 4;
            // 
            // HPLabel
            // 
            this.HPLabel.AutoSize = true;
            this.HPLabel.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HPLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HPLabel.Location = new System.Drawing.Point(38, 56);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(23, 16);
            this.HPLabel.TabIndex = 3;
            this.HPLabel.Text = "HP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DemonSlayerRPG.Properties.Resources.heart2;
            this.pictureBox1.Location = new System.Drawing.Point(23, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pm1HP
            // 
            this.pm1HP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pm1HP.Location = new System.Drawing.Point(67, 57);
            this.pm1HP.Name = "pm1HP";
            this.pm1HP.Size = new System.Drawing.Size(100, 14);
            this.pm1HP.TabIndex = 1;
            // 
            // mcName
            // 
            this.mcName.AutoSize = true;
            this.mcName.ForeColor = System.Drawing.Color.Silver;
            this.mcName.Location = new System.Drawing.Point(23, 32);
            this.mcName.Name = "mcName";
            this.mcName.Size = new System.Drawing.Size(64, 20);
            this.mcName.TabIndex = 0;
            this.mcName.Text = "empty";
            // 
            // sceneBox
            // 
            this.sceneBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sceneBox.Location = new System.Drawing.Point(311, 59);
            this.sceneBox.Name = "sceneBox";
            this.sceneBox.Size = new System.Drawing.Size(640, 360);
            this.sceneBox.TabIndex = 6;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1143, 764);
            this.Controls.Add(this.screen);
            this.Font = new System.Drawing.Font("ProggyCleanTT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Game";
            this.Text = "DSRPG";
            this.screen.ResumeLayout(false);
            this.playerTextbox.ResumeLayout(false);
            this.playerTextbox.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ProgressBar pm1HP;
        private System.Windows.Forms.Label mcName;
        private System.Windows.Forms.Label SPLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label HPLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.Label pm4Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label pm3Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label pm2Name;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button skillsButton;
        private System.Windows.Forms.Button defendButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button partyButton;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Panel playerTextbox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox playerText;
        private System.Windows.Forms.Panel sceneBox;
    }
}

