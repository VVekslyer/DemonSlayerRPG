
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
            HP = MaxHP;
            SP = MaxSP;

            Skills.Add(new Skill("Attack", Type: "Offense", Description: "Minor damage to one foe.", DMGMultiplier: -1.0, HPCost: 2, SPCost: 0 ));
            Skills.Add(new Skill("Defend", Type: "Defense", Description: "Reduce/Block incoming damage.", DMGMultiplier: 1.0, HPCost: 0, SPCost: 0));
            Skills.Add(new Skill(BreathStyle + " Breathing", Type: "Focus", Description: "Focus to use a skill.", DMGMultiplier: 0, HPCost: 0, SPCost: 20));
            Skills.Add(new Skill("Spare",  Type: "Pacifist", Description: "Attempt to convince a foe to stop fighting.", DMGMultiplier: 0, HPCost: 0, SPCost: 0));
            

            if (BreathStyle == "Water")
                Skills.Add(new Skill("1st Form : Surface Slice", "Offense", "Light concentrated damage to one foe.", DMGMultiplier: -2.5, HPCost: 5, SPCost: 0));

            else if (BreathStyle == "Thunder")
                Skills.Add(new Skill("1st Form : Thunderclap & Flash", "Offense", "Medium concentrated damage to one foe.", DMGMultiplier: -3.0, HPCost: 5, SPCost: 0));

            else if (BreathStyle == "Beast")
                Skills.Add(new Skill("1st Form : Pierce & Extract", "Offense", "Light concentrated damage to one foe.", DMGMultiplier: -2.5, HPCost: 5, SPCost: 0));

            else if (BreathStyle == "Fire")
                Skills.Add(new Skill("1st Form : Waltz", "Offense", "Heavy concentrated damage to one foe.", DMGMultiplier: -4.0, HPCost: 15, SPCost: 5));
            
        }

    }
}
