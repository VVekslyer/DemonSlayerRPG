using System.Drawing;

namespace DemonSlayerRPG.components.enemies
{
    class Boss : Demon
    {
        public Boss(string Name, Image sprite, int MaxHP, int MaxSP, int Strength, int Focus, int Kindness) : base(Name, sprite, MaxSP, MaxSP, Strength, Focus, Kindness)
        {
            this.Name = Name;
            this.MaxHP = MaxHP;
            this.MaxSP = MaxSP;
            this.Strength = Strength;
            this.Focus = Focus;
            this.Kindness = Kindness;
            // Default sprite: Properties.Resources.temple_demon
            HP = MaxHP;
            SP = MaxSP;
        }

    }
}
