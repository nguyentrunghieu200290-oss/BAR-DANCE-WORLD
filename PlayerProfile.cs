using System;
using UnityEngine;

namespace BarDanceWorld
{
    [Serializable]
    public class PlayerProfile
    {
        public string displayName = "New Dancer";
        public int level = 1;
        public int experience = 0;
        public int coins = 1000;
    }
}
