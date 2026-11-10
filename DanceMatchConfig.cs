using UnityEngine;

namespace BarDanceWorld
{
    [CreateAssetMenu(fileName = "DanceMatchConfig", menuName = "BAR DANCE WORLD/Match Config")]
    public class DanceMatchConfig : ScriptableObject
    {
        [Min(1)] public int playersPerTeam = 5;
        [Min(1)] public int rounds = 5;
        [Min(0)] public int winnerCoins = 1000;
        [Min(0)] public int participationCoins = 400;
        [Min(0)] public int mvpBonusCoins = 300;
    }
}
