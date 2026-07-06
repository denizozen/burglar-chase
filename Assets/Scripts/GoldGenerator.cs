using UnityEngine;

/// <summary>Spawns Gold prefabs at a random interval, starting after a delay.</summary>
public class GoldGenerator : ItemGeneratorBase
{
    public GameObject gold;
    public float speed = 0.25f;

    protected override GameObject ItemPrefab => gold;
    protected override float InitialDelay => 5f;
    protected override float GetSpawnInterval() => Random.Range(2f, 10f);

    protected override void ConfigureSpawnedItem(GameObject spawned)
    {
        spawned.GetComponent<GoldScript>().goldGenerator = this;
    }
}
