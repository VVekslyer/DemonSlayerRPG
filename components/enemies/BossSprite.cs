using System.Drawing;
using System.Windows.Forms;

namespace DemonSlayerRPG.components.enemies
{
    public partial class BossSprite : UserControl
    {
        BossSprite(Boss boss)
        {
            InitializeComponent();
            //Sprite.Image = boss.sprite;
        }

    }
}