using static DemonSlayerRPG.Globals;
using System.Drawing;
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
            mcName.ForeColor = Color.WhiteSmoke;
            mcName.Text = PlayerName;
            mcHP.Value = 100;
            mcSP.Value = 100;
            Loading = false;
        }

        private void AttackBtn_Click(object sender, System.EventArgs e)
        {
            if (InBattle)
            {
                if (!ChoosingTarget)
                {
                    ChoosingTarget = true;
                    AttackBtn.ForeColor = Color.WhiteSmoke;
                }
                else
                {
                    ChoosingTarget = false;
                    AttackBtn.ForeColor = Color.NavajoWhite;
                }
            }
        }

        private void DefendBtn_Click(object sender, System.EventArgs e)
        {

        }
    }
}
