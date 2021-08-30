
namespace DemonSlayerRPG.components.enemies
{
    partial class DemonSprite
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
            this.Sprite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sprite)).BeginInit();
            this.SuspendLayout();
            // 
            // Sprite
            // 
            this.Sprite.Location = new System.Drawing.Point(0, 0);
            this.Sprite.Name = "Sprite";
            this.Sprite.Size = new System.Drawing.Size(140, 190);
            this.Sprite.TabIndex = 0;
            this.Sprite.TabStop = false;
            this.Sprite.WaitOnLoad = true;
            // 
            // DemonSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.Sprite);
            this.Name = "DemonSprite";
            this.Size = new System.Drawing.Size(140, 190);
            ((System.ComponentModel.ISupportInitialize)(this.Sprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Sprite;
    }
}
