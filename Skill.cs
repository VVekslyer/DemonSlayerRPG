
namespace DemonSlayerRPG
{
    class Skill
    {
        public string Name;
        public string Type;
        public string Description;
        public double DMGMultiplier;  // Multiplies off the Strength or Focus attribute.
        public int SPCost;
        public int HPCost;

        public Skill(string Name, string Type, string Description, double DMGMultiplier, int HPCost, int SPCost)
        {
            this.Name = Name;
            this.Type = Type;
            this.Description = Description;
            this.DMGMultiplier = DMGMultiplier;
            this.HPCost = HPCost;
            this.SPCost = SPCost;
        }
    }
}
