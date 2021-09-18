using System;
using System.Collections.Generic;
using static DemonSlayerRPG.Globals;

namespace DemonSlayerRPG
{
    class Party : List<PartyMember>
    { 
        public Party()
        {
            
        }

        public void CreateMC(string PlayerName)
        {
            Add(new PartyMember(Name: PlayerName, BreathStyle: "Water", MaxHP: 30, MaxSP: 20, Strength: 3, Focus: 3, Kindness: 3));
        }
    }
}
