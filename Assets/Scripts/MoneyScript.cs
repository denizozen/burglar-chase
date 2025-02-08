using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    public MoneyGenerator moneyGenerator;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * moneyGenerator.speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "die")
        {
            Destroy(gameObject);
        }
    }
}
