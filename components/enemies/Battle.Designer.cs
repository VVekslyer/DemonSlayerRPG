
namespace DemonSlayerRPG.components.enemies
{
    partial class Battle
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftDemon = new System.Windows.Forms.PictureBox();
            this.midDemon = new System.Windows.Forms.PictureBox();
            this.rightDemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftDemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midDemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDemon)).BeginInit();
            this.SuspendLayout();
            // 
            // leftDemon
            // 
            this.leftDemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftDemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftDemon.Location = new System.Drawing.Point(132, 190);
            this.leftDemon.Name = "leftDemon";
            this.leftDemon.Size = new System.Drawing.Size(110, 167);
            this.leftDemon.TabIndex = 0;
            this.leftDemon.TabStop = false;
            this.leftDemon.Click += new System.EventHandler(this.leftDemon_Click);
            // 
            // midDemon
            // 
            this.midDemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.midDemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.midDemon.Location = new System.Drawing.Point(264, 190);
            this.midDemon.Name = "midDemon";
            this.midDemon.Size = new System.Drawing.Size(110, 167);
            this.midDemon.TabIndex = 1;
            this.midDemon.TabStop = false;
            this.midDemon.Click += new System.EventHandler(this.midDemon_Click);
            // 
            // rightDemon
            // 
            this.rightDemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightDemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightDemon.Location = new System.Drawing.Point(399, 190);
            this.rightDemon.Name = "rightDemon";
            this.rightDemon.Size = new System.Drawing.Size(110, 167);
            this.rightDemon.TabIndex = 2;
            this.rightDemon.TabStop = false;
            this.rightDemon.Click += new System.EventHandler(this.rightDemon_Click);
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.rightDemon);
            this.Controls.Add(this.midDemon);
            this.Controls.Add(this.leftDemon);
            this.Font = new System.Drawing.Font("ProggyCleanTT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Battle";
            this.Size = new System.Drawing.Size(640, 360);
            ((System.ComponentModel.ISupportInitialize)(this.leftDemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midDemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox leftDemon;
        public System.Windows.Forms.PictureBox midDemon;
        public System.Windows.Forms.PictureBox rightDemon;
    }
}
