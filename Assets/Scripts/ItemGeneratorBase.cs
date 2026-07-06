using System.Collections;
using UnityEngine;

/// <summary>
/// Base behaviour for spawners that repeatedly instantiate a prefab at a
/// (possibly randomized) interval and position, then configure the spawned
/// instance (e.g. wiring it back to this generator).
/// </summary>
public abstract class ItemGeneratorBase : MonoBehaviour
{
    /// <summary>The prefab this generator spawns.</summary>
    protected abstract GameObject ItemPrefab { get; }

    /// <summary>Delay before the spawn loop starts, in seconds.</summary>
    protected virtual float InitialDelay => 0f;

    /// <summary>Where the next instance should be spawned. Defaults to this generator's position.</summary>
    protected virtual Vector3 GetSpawnPosition() => transform.position;

    /// <summary>How long to wait before spawning the next instance.</summary>
    protected abstract float GetSpawnInterval();

    /// <summary>Called on each newly spawned instance so it can be wired up (e.g. set its generator reference).</summary>
    protected abstract void ConfigureSpawnedItem(GameObject spawned);

    /// <summary>Optional setup hook, run once before the spawn loop starts.</summary>
    protected virtual void Initialize() { }

    protected IEnumerator Start()
    {
        Initialize();
        if (InitialDelay > 0f)
        {
            yield return new WaitForSeconds(InitialDelay);
        }
        StartCoroutine(GenerateItems());
    }

    protected IEnumerator GenerateItems()
    {
        while (true)
        {
            GameObject spawned = Instantiate(ItemPrefab, GetSpawnPosition(), transform.rotation);
            ConfigureSpawnedItem(spawned);
            yield return new WaitForSeconds(GetSpawnInterval());
        }
    }
}
