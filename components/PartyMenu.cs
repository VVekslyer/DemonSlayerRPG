using static DemonSlayerRPG.Globals;
using System.Windows.Forms;

namespace DemonSlayerRPG.components
{
    partial class PartyMenu : UserControl
    {   
        public PartyMenu()
        {
            InitializeComponent();
        }
        
        public void UpdateMCName(string PlayerName)
        {
            mcName.Text = PlayerName;
        }
    }
}
