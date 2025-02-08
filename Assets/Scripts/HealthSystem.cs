using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public GameObject heartPrefab;
    public PlayerScript playerHealth;
    List<HealthBar> hearts = new List<HealthBar>();

    void Start()
    {
        DrawHearts();
    }

    private void OnEnable()
    {
        playerHealth.OnPlayerDamaged += DrawHearts;
    }
    
    private void OnDisable()
    {
        playerHealth.OnPlayerDamaged -= DrawHearts;
    }
    public void DrawHearts()
    {
        ClearHearts();
        for (int i = 0; i < 5; i++)
        {
            CreateEmptyHeart();
        }

        for (int i = 0; i < hearts.Count; i++)
        {
            int heartStatusRemainder = Mathf.Clamp(playerHealth.currentHealth/10 - (i * 2), 0, 2);
            hearts[i].setHeartStatus((HeartStatus)heartStatusRemainder);
        }
    }

    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.SetParent(transform);

        HealthBar heartComponent = newHeart.GetComponent<HealthBar>();
        heartComponent.setHeartStatus(HeartStatus.Empty);
        hearts.Add(heartComponent);
    }

    public void ClearHearts()
    {
        foreach (Transform t in transform)
        {
            Destroy(t.gameObject);
        }

        hearts = new List<HealthBar>();
    }

}
