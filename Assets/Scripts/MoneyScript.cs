using UnityEngine;

/// <summary>Scrolling money pickup.</summary>
public class MoneyScript : MovingItemBase
{
    public MoneyGenerator moneyGenerator;

    protected override float Speed => moneyGenerator.speed;
}
