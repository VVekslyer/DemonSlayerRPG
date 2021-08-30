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
        
        public void InitiateMC(string PlayerName)
        {
            CurrentParty.CreateMC(PlayerName);
            mcName.ForeColor = System.Drawing.Color.WhiteSmoke;
            mcName.Text = PlayerName;
            mcHP.Value = 100;
            mcSP.Value = 100;
        }
    }
}
