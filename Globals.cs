using System.Drawing;
using DemonSlayerRPG.components.enemies;

namespace DemonSlayerRPG
{
    static class Globals
    {
        // Story
        public static Party CurrentParty = new Party();
        public static bool Loading = false;
        public static bool InBattle = false;
        public static bool BattleWon = false;
        public static Bitmap[] Sprite = new Bitmap[]
        {
            Properties.Resources.temple_demon
        };
        public static Battle CurrentBattle;
        public static Demon CurrentDemon;


        public static void BeginBattle(Battle B)
        {
            CurrentBattle = B;
            Loading = true;
        }


        // Battle
        public static bool ChoosingTarget = false;
        public static bool PlayerTurn = false;
        public static bool EnemyTurn = false;
        public static int Turns = 1;
        public static int Turn = 0;

    }
}
