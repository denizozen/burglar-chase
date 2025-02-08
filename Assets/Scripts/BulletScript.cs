using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class BulletScript : MonoBehaviour
{
    public BulletGenerator bulletGenerator;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * bulletGenerator.speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "die")
        {
            Destroy(gameObject);
        }
    }
}
