
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
            this.DialogueBox = new DemonSlayerRPG.components.DialogueBox();
            this.sceneBox = new System.Windows.Forms.Panel();
            this.partyMenu = new DemonSlayerRPG.components.PartyMenu();
            this.screen = new System.Windows.Forms.Panel();
            this.screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogueBox
            // 
            this.DialogueBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DialogueBox.Font = new System.Drawing.Font("ProggyCleanTT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DialogueBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DialogueBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DialogueBox.Location = new System.Drawing.Point(311, 476);
            this.DialogueBox.Name = "DialogueBox";
            this.DialogueBox.Size = new System.Drawing.Size(640, 101);
            this.DialogueBox.TabIndex = 1;
            this.DialogueBox.Click += new System.EventHandler(this.DialogueBox_Click);
            // 
            // sceneBox
            // 
            this.sceneBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sceneBox.Location = new System.Drawing.Point(311, 59);
            this.sceneBox.Name = "sceneBox";
            this.sceneBox.Size = new System.Drawing.Size(640, 360);
            this.sceneBox.TabIndex = 6;
            // 
            // partyMenu
            // 
            this.partyMenu.Font = new System.Drawing.Font("ProggyCleanTT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partyMenu.Location = new System.Drawing.Point(0, 0);
            this.partyMenu.Margin = new System.Windows.Forms.Padding(5);
            this.partyMenu.Name = "partyMenu";
            this.partyMenu.Size = new System.Drawing.Size(197, 680);
            this.partyMenu.TabIndex = 7;
            this.partyMenu.TabStop = false;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(21)))));
            this.screen.Controls.Add(this.partyMenu);
            this.screen.Controls.Add(this.sceneBox);
            this.screen.Controls.Add(this.DialogueBox);
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
            this.Text = "DSRPG";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.screen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private components.DialogueBox DialogueBox;
        private System.Windows.Forms.Panel sceneBox;
        private System.Windows.Forms.Panel screen;
        public components.PartyMenu partyMenu;
    }
}

