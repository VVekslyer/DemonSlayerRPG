using System;
using System.Collections.Generic;

namespace DemonSlayerRPG
{
    class Party : List<PartyMember>
    { 
        public Party()
        {
            
        }

        public delegate void MentionNewMC(string PlayerName);

        public void CreateMC(string PlayerName, Action<string> updateMCName)
        {
            //mentionNewMC(PlayerName);
            updateMCName(PlayerName);
            Add(new PartyMember(Name: PlayerName, BreathStyle: "Water", MaxHP: 30, MaxSP: 20, Strength: 3, Focus: 3, Kindness: 3));
        }
    }
}
