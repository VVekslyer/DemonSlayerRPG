using System.Collections.Generic;

namespace DemonSlayerRPG
{
    class Character
    {
        public string Name;
        public int MaxHP;
        public int MaxSP;
        public int HP;
        public int SP;

        public int Strength; // How much DMG is dealt and sustained.
        public int Focus;    // How much DMG do skills deal and the amount of SP they use.
        public int Kindness; // Chances of sparing a demon.

        public List<Skill> Skills = new List<Skill>();

    }
}
