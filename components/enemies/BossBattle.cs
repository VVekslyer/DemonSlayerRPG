using System.Drawing;
using System.Windows.Forms;

namespace DemonSlayerRPG.components.enemies
{
    public partial class BossBattle : UserControl
    {
        public BossBattle(BossSprite boss)
        {
            InitializeComponent();
            Controls.Add(boss);
            boss.Location = new Point(262, 164);
        }
    }
}
