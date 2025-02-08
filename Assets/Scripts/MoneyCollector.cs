using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void collectMoney(int moneyValue)
    {
        money += moneyValue;
        text.text = money.ToString();
    }

    public void spendMoney(int lifeCost)
    {
        money -= lifeCost;
        text.text = money.ToString();
    }
}
