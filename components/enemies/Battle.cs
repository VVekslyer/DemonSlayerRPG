using System.Drawing;
using System.Windows.Forms;
using static DemonSlayerRPG.Globals;

namespace DemonSlayerRPG.components.enemies
{
    partial class Battle : UserControl
    {
        Demon LeftDemon;
        Demon MidDemon;
        Demon RightDemon;

        public Battle(Demon demon1)
        {
            InitializeComponent();
            Controls.Add(demon1.Sprite);
            demon1.Sprite.Location = new Point(265, 180);
            MidDemon = demon1;
        }

        public Battle(Demon demon1, Demon demon2)
        {
            InitializeComponent();
            Controls.Add(demon1.Sprite);
            Controls.Add(demon2.Sprite);
            demon1.Sprite.Location = new Point(165, 180);
            demon2.Sprite.Location = new Point(345, 180);
            LeftDemon = demon1;
            RightDemon = demon2;
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
            LeftDemon = demon1;
            MidDemon = demon2;
            RightDemon = demon3;
        }

        private void midDemon_Click(object sender, System.EventArgs e)
        {
            AttackDemon(MidDemon);
            if (MidDemon.HP <= 0)
            {
                Controls.Clear();
                Dispose();
                CurrentDemon = null;
                
            }
        }

        private void leftDemon_Click(object sender, System.EventArgs e)
        {
            AttackDemon(LeftDemon);
        }

        private void rightDemon_Click(object sender, System.EventArgs e)
        {
            AttackDemon(RightDemon);
        }

        private void AttackDemon(Demon D)
        {
            int DmgDealt = CurrentParty[Turn].Strength * 2;
            D.HP -= DmgDealt;
            CurrentDemon.HP -= DmgDealt;
        }

    }
}
