using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour
{
    public GoldGenerator goldGenerator;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * goldGenerator.speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "die")
        {
            Destroy(gameObject);
        }
    }
}
