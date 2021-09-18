using System.Drawing;

namespace DemonSlayerRPG.components.enemies
{
    class Boss : Demon
    {
        public Boss(string Name, Image sprite, int MaxHP, int MaxSP, int Strength, int Focus, int Kindness, string FirstMessage) : base(Name, sprite, MaxSP, MaxSP, Strength, Focus, Kindness, FirstMessage)
        {
            this.Name = Name;
            this.MaxHP = MaxHP;
            this.MaxSP = MaxSP;
            this.Strength = Strength;
            this.Focus = Focus;
            this.Kindness = Kindness;
            this.FirstMessage = FirstMessage;
            // Default sprite: Properties.Resources.temple_demon
            HP = MaxHP;
            SP = MaxSP;
        }

    }
}
