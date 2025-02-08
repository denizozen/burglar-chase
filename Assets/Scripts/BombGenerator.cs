using System.Collections;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject bomb;
    
    private float minSpeed = 0.1f;
    private float maxSpeed = 0.3f;
    public float currentSpeed;
    private float timer;
    private float timeSinceStart;
    private int x, y;

    void Start()
    {
        x = 2;
        y = 15; 
        currentSpeed = minSpeed;
        StartCoroutine(generateBombs());
    }

    public IEnumerator generateBombs()
    {
        while (true)
        {
            GameObject bombClones = Instantiate(bomb, transform.position, transform.rotation);
            bombClones.GetComponent<BombScript>().bombGenerator = this;
            timer = Random.Range(x, y);
            yield return new WaitForSeconds(timer);
        }

    }

    void Update()
    {
        
        if (timeSinceStart > 30 && timeSinceStart < 60)
        {
            y = 9;
            maxSpeed = 0.45f;
        }
        if (timeSinceStart > 60 && timeSinceStart < 180)
        {
            y = 5;
            maxSpeed = 0.7f;
        }
        currentSpeed = Random.Range(minSpeed, maxSpeed);
    }
}
