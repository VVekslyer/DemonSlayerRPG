using System.Drawing;
using System.Windows.Forms;

namespace DemonSlayerRPG.components.enemies
{
    partial class Battle : UserControl
    {
        public Battle(Demon demon1)
        {
            InitializeComponent();
            Controls.Add(demon1.Sprite);
            demon1.Sprite.Location = new Point(265, 180);
        }

        public Battle(Demon demon1, Demon demon2)
        {
            InitializeComponent();
            Controls.Add(demon1.Sprite);
            Controls.Add(demon2.Sprite);
            demon1.Sprite.Location = new Point(165, 180);
            demon2.Sprite.Location = new Point(345, 180);
        }


        public Battle(Demon demon1, Demon demon2, Demon demon3)
        {
            InitializeComponent();
            Controls.Add(demon1.Sprite);
            Controls.Add(demon2.Sprite);
            Controls.Add(demon3.Sprite);
            demon1.Sprite.Location = new Point(135, 180);
            demon2.Sprite.Location = new Point(265, 180);
            demon3.Sprite.Location = new Point(400, 180);
        }

    }
}
