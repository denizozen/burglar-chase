using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 0.001f;
    private float timer;
    private Vector3 pos;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(30);
        StartCoroutine(generateBullets());
    }

    public IEnumerator generateBullets()
    {
        while(true)
        {
            pos = new Vector3(transform.position.x, Random.Range(-3.7f, -0.29f), 0);
            GameObject bulletClones = Instantiate(bullet, pos, transform.rotation);
            bulletClones.GetComponent<BulletScript>().bulletGenerator = this;
            timer = Random.Range(2, 7);
            yield return new WaitForSeconds(timer);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
