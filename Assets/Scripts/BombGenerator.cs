using UnityEngine;

/// <summary>
/// Spawns Bomb prefabs at a randomized interval that ramps up (shorter interval,
/// higher speed) the longer the run continues.
/// </summary>
public class BombGenerator : ItemGeneratorBase
{
    public GameObject bomb;

    private float minSpeed = 0.1f;
    private float maxSpeed = 0.3f;
    public float currentSpeed;
    private float timeSinceStart;
    private int minInterval, maxInterval;

    protected override GameObject ItemPrefab => bomb;

    protected override void Initialize()
    {
        minInterval = 2;
        maxInterval = 15;
        currentSpeed = minSpeed;
    }

    protected override float GetSpawnInterval() => Random.Range(minInterval, maxInterval);

    protected override void ConfigureSpawnedItem(GameObject spawned)
    {
        spawned.GetComponent<BombScript>().bombGenerator = this;
    }

    void Update()
    {
        timeSinceStart += Time.deltaTime;

        if (timeSinceStart > 30 && timeSinceStart < 60)
        {
            maxInterval = 9;
            maxSpeed = 0.45f;
        }
        if (timeSinceStart > 60 && timeSinceStart < 180)
        {
            maxInterval = 5;
            maxSpeed = 0.7f;
        }
        currentSpeed = Random.Range(minSpeed, maxSpeed);
    }
}
