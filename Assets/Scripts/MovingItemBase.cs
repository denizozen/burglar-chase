using UnityEngine;

/// <summary>
/// Base behaviour for scrolling obstacles/pickups: moves left every frame at
/// <see cref="Speed"/> and destroys itself when it hits a matching trigger.
/// </summary>
public abstract class MovingItemBase : MonoBehaviour
{
    /// <summary>Current leftward movement speed, sourced from the item's generator.</summary>
    protected abstract float Speed { get; }

    void Update()
    {
        transform.Translate(Vector2.left * Speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ShouldDestroyOnTrigger(collision))
        {
            Destroy(gameObject);
        }
    }

    /// <summary>Whether this item should be destroyed on the given trigger collision. Default: the "die" boundary.</summary>
    protected virtual bool ShouldDestroyOnTrigger(Collider2D collision)
    {
        return collision.gameObject.CompareTag("die");
    }
}
