using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DemonSlayerRPG.components.enemies
{
    class Demon : Character
    {
        protected string DemonStyle = "Demon Blood Art";
        public DemonSprite Sprite;
        public Image img;
        public string FirstMessage;

        public Demon(string Name, Image img, int MaxHP, int MaxSP, int Strength, int Focus, int Kindness, string FirstMessage)
        {
            this.Name = Name;
            this.MaxHP = MaxHP;
            this.MaxSP = MaxSP;
            this.Strength = Strength;
            this.Focus = Focus;
            this.Kindness = Kindness;
            this.img = img; // Default sprite: Properties.Resources.temple_demon
            this.FirstMessage = FirstMessage;

            Sprite = new DemonSprite(Name) { BackgroundImage = img };
            HP = MaxHP;
            SP = MaxSP;

            Skills.Add(new Skill("Attack", Type: "Offense", Description: "Minor damage to one foe.", DMGMultiplier: -1.0, HPCost: 2, SPCost: 0));
            Skills.Add(new Skill("Defend", Type: "Defense", Description: "Reduce/Block incoming damage.", DMGMultiplier: 1.0, HPCost: 0, SPCost: 0));
            Skills.Add(new Skill(DemonStyle, Type: "Focus", Description: "Unleash a devastating thrust.", DMGMultiplier: 2.0, HPCost: 0, SPCost: 10));

        }
    }
}

