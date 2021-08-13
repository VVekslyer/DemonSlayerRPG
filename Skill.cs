using System;
using System.Collections.Generic;
using System.Text;

namespace DemonSlayerRPG
{
    class Skill
    {
        protected string SkillName;
        protected string Type;
        protected string Description;
        protected double DMGMultiplier;  // Multiplies off the Strength or Focus attribute.
        protected int SPCost;
        protected int HPCost;

        public Skill(string SkillName, string Type, string Description, double DMGMultiplier, int HPCost, int SPCost)
        {
            this.SkillName = SkillName;
            this.Type = Type;
            this.Description = Description;
            this.DMGMultiplier = DMGMultiplier;
            this.HPCost = HPCost;
            this.SPCost = SPCost;
        }
    }
}
