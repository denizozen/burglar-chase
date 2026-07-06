using UnityEngine;

/// <summary>Falling bomb obstacle; destroys itself on hitting the player or the "die" boundary.</summary>
public class BombScript : MovingItemBase
{
    public BombGenerator bombGenerator;

    protected override float Speed => bombGenerator.currentSpeed;

    protected override bool ShouldDestroyOnTrigger(Collider2D collision)
    {
        return collision.gameObject.CompareTag("die") || collision.gameObject.CompareTag("player");
    }
}
