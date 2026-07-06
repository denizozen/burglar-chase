using UnityEngine;

/// <summary>Scrolling bullet obstacle.</summary>
public class BulletScript : MovingItemBase
{
    public BulletGenerator bulletGenerator;

    protected override float Speed => bulletGenerator.speed;
}
