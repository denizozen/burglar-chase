using UnityEngine;

/// <summary>Spawns Money prefabs at a random height and interval, starting after a delay.</summary>
public class MoneyGenerator : ItemGeneratorBase
{
    public GameObject money;
    public float speed = 1f;

    protected override GameObject ItemPrefab => money;
    protected override float InitialDelay => 10f;
    protected override Vector3 GetSpawnPosition() => new Vector3(transform.position.x, Random.Range(-3.7f, -0.29f), 0);
    protected override float GetSpawnInterval() => Random.Range(2f, 5f);

    protected override void ConfigureSpawnedItem(GameObject spawned)
    {
        spawned.GetComponent<MoneyScript>().moneyGenerator = this;
    }
}
