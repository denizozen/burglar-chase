using UnityEngine;
using UnityEngine.UI;

/// <summary>Tracks the player's money total and keeps its on-screen display in sync.</summary>
public class MoneyCollector : MonoBehaviour
{
    public static MoneyCollector instance;
    public Text text;
    public int money;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void CollectMoney(int moneyValue)
    {
        money += moneyValue;
        text.text = money.ToString();
    }

    public void SpendMoney(int lifeCost)
    {
        money -= lifeCost;
        text.text = money.ToString();
    }
}
