using System.Collections.Generic;

namespace DemonSlayerRPG
{
    class Character
    {
        public string Name;
        protected int MaxHP;
        protected int MaxSP;
        protected int HP;
        protected int SP;

        protected int Strength; // How much DMG is dealt and sustained.
        protected int Focus;    // How much DMG do skills deal and the amount of SP they use.
        protected int Kindness; // Chances of sparing a demon.

        public List<Skill> Skills = new List<Skill>();

    }
}
