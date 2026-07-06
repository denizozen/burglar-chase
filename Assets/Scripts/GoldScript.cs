using UnityEngine;

/// <summary>Scrolling gold pickup.</summary>
public class GoldScript : MovingItemBase
{
    public GoldGenerator goldGenerator;

    protected override float Speed => goldGenerator.speed;
}
