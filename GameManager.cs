using UnityEngine;

namespace BarDanceWorld
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [SerializeField] private int startingCoins = 1000;
        public int Coins { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            Coins = Mathf.Max(0, startingCoins);
        }

        public void AddCoins(int amount)
        {
            if (amount > 0)
                Coins += amount;
        }

        public bool TrySpendCoins(int amount)
        {
            if (amount <= 0 || Coins < amount)
                return false;

            Coins -= amount;
            return true;
        }
    }
}
