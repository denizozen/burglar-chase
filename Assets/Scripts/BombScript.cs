using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class BombScript : MonoBehaviour
{
    public BombGenerator bombGenerator;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * bombGenerator.currentSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "die" || collision.gameObject.tag == "player")
        {
            Destroy(gameObject);
            
        }
    }
}
