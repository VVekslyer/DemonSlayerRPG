
namespace DemonSlayerRPG
{
    partial class Game
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.sceneBox = new System.Windows.Forms.Panel();
            this.IntroScreen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PartyMenu = new DemonSlayerRPG.components.PartyMenu();
            this.screen = new System.Windows.Forms.Panel();
            this.sceneBox.SuspendLayout();
            this.IntroScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // sceneBox
            // 
            this.sceneBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sceneBox.Controls.Add(this.IntroScreen);
            this.sceneBox.Location = new System.Drawing.Point(311, 59);
            this.sceneBox.Name = "sceneBox";
            this.sceneBox.Size = new System.Drawing.Size(640, 360);
            this.sceneBox.TabIndex = 6;
            this.sceneBox.Tag = "battle";
            // 
            // IntroScreen
            // 
            this.IntroScreen.Controls.Add(this.label1);
            this.IntroScreen.Controls.Add(this.Logo);
            this.IntroScreen.Location = new System.Drawing.Point(15, 3);
            this.IntroScreen.Name = "IntroScreen";
            this.IntroScreen.Size = new System.Drawing.Size(609, 350);
            this.IntroScreen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Determination Mono Web", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(413, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Made by VVekslyer";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(164, 18);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(280, 300);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // PartyMenu
            // 
            this.PartyMenu.Font = new System.Drawing.Font("ProggyCleanTT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PartyMenu.Location = new System.Drawing.Point(0, 0);
            this.PartyMenu.Margin = new System.Windows.Forms.Padding(5);
            this.PartyMenu.Name = "PartyMenu";
            this.PartyMenu.Size = new System.Drawing.Size(197, 680);
            this.PartyMenu.TabIndex = 7;
            this.PartyMenu.TabStop = false;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(21)))));
            this.screen.Controls.Add(this.PartyMenu);
            this.screen.Controls.Add(this.sceneBox);
            this.screen.Location = new System.Drawing.Point(75, 66);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1008, 680);
            this.screen.TabIndex = 0;
            this.screen.Click += new System.EventHandler(this.screen_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1165, 809);
            this.Controls.Add(this.screen);
            this.Font = new System.Drawing.Font("ProggyCleanTT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSRPG";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.sceneBox.ResumeLayout(false);
            this.IntroScreen.ResumeLayout(false);
            this.IntroScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.screen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private components.DialogueBox DialogueBox;
        private System.Windows.Forms.Panel screen;
        public components.PartyMenu PartyMenu;
        public System.Windows.Forms.Panel sceneBox;
        private System.Windows.Forms.Panel IntroScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
    }
}

