using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldGenerator : MonoBehaviour
{

    public GameObject gold;
    public float speed = 0.25f;
    private float timer;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        StartCoroutine(generateGolds());
    }
    
    public IEnumerator generateGolds()
    {
        while(true){
            GameObject goldClones = Instantiate(gold, transform.position, transform.rotation);
            goldClones.GetComponent<GoldScript>().goldGenerator = this;
            timer = Random.Range(2, 10);
            yield return new WaitForSeconds(timer);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
