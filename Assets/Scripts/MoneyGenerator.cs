using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyGenerator : MonoBehaviour
{
    public GameObject money;
    public float speed = 1f;
    private float timer;
    private Vector3 pos;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(10);
        StartCoroutine(generateMoney());
    }

    public IEnumerator generateMoney()
    {
        while(true)
        {
            pos = new Vector3(transform.position.x, Random.Range(-3.7f, -0.29f), 0);
            GameObject moneyClones = Instantiate(money, pos, transform.rotation);
            moneyClones.GetComponent<MoneyScript>().moneyGenerator = this;
            timer = Random.Range(2, 5);
            yield return new WaitForSeconds(timer);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
