using System;
using System.Collections.Generic;
using System.Text;

namespace DemonSlayerRPG
{
    class PartyMember : Character
    {
        protected string BreathStyle;

        public PartyMember(string Name, string BreathStyle, int MaxHP, int MaxSP, int Strength, int Focus, int Kindness)
        {
            this.Name = Name;
            this.BreathStyle = BreathStyle;
            this.MaxHP = MaxHP;
            this.MaxSP = MaxSP;
            this.Strength = Strength;
            this.Focus = Focus;
            this.Kindness = Kindness;

            Skills.Add(new Skill("Attack", "Offense", "Minor damage to one foe.", -1.0, 2, 0));
            Skills.Add(new Skill("Defend", "Defense", "Reduce/Block incoming damage.", 1.0, 0, 0));
            Skills.Add(new Skill(BreathStyle + "Breath", "Focus", "Focus to use a skill.", 0, 0, 20));
            Skills.Add(new Skill("Spare", "Pacifist", "Attempt to convince a foe to stop fighting.", 0, 0, 0));

            if (BreathStyle == "Water")
                Skills.Add(new Skill("1st Form : Surface Slice", "Offense", "Light concentrated damage to one foe.", -2.5, 5, 0));

            else if (BreathStyle == "Thunder")
                Skills.Add(new Skill("1st Form : Thunderclap & Flash", "Offense", "Medium concentrated damage to one foe.", -3.0, 5, 0));

            else if (BreathStyle == "Beast")
                Skills.Add(new Skill("1st Form : Pierce & Extract", "Offense", "Light concentrated damage to one foe.", -2.5, 5, 0));

            else if (BreathStyle == "Fire")
                Skills.Add(new Skill("1st Form : Waltz", "Offense", "Heavy concentrated damage to one foe.", -4.0, 15, 5));
        }

    }
}
