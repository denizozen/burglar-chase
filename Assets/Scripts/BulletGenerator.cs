using UnityEngine;

/// <summary>Spawns Bullet prefabs at a random height and interval, starting after a delay.</summary>
public class BulletGenerator : ItemGeneratorBase
{
    public GameObject bullet;
    public float speed = 0.001f;

    protected override GameObject ItemPrefab => bullet;
    protected override float InitialDelay => 30f;
    protected override Vector3 GetSpawnPosition() => new Vector3(transform.position.x, Random.Range(-3.7f, -0.29f), 0);
    protected override float GetSpawnInterval() => Random.Range(2f, 7f);

    protected override void ConfigureSpawnedItem(GameObject spawned)
    {
        spawned.GetComponent<BulletScript>().bulletGenerator = this;
    }
}
