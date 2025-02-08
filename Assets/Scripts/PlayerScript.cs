using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private float jump = 400 ;
    private bool isGrounded = false;
    private Rigidbody2D rb;
    public int health = 20;
    public int money;
    public int currentHealth;
    public Text text;
    private float timeSinceStart;
    public GameObject gameOver;
    public SpriteRenderer spriteR;
    public Sprite hurtSprite;
    public Sprite normalSprite;

    public event Action OnPlayerDamaged;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = health;
    }
    void Update()
    {
        checkLife();
        timeSinceStart += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isGrounded)
            {
                rb.AddForce(Vector2.up * jump);
                isGrounded = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (!isGrounded)
            {
                rb.AddForce(Vector2.down * jump);
                isGrounded = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (MoneyCollector.instance.money > 100)
            {
                currentHealth += 20;
                MoneyCollector.instance.spendMoney(100);
                OnPlayerDamaged?.Invoke();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            if (isGrounded == false)
            {
                isGrounded = true;
            }
        }
        
        if (collision.gameObject.CompareTag("bomb"))
        {
            Destroy(collision.gameObject);
            currentHealth -= 20;
            OnPlayerDamaged?.Invoke();
            StartCoroutine(spriteChange());
        }
        
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            currentHealth -= 10;
            OnPlayerDamaged?.Invoke();
            StartCoroutine(spriteChange());
        }

        if (collision.gameObject.CompareTag("money"))
        {
            Destroy(collision.gameObject);
            MoneyCollector.instance.collectMoney(5);
        }

        if (collision.gameObject.CompareTag("gold"))
        {
            Destroy(collision.gameObject);
            MoneyCollector.instance.collectMoney(10);
        }
    }

    void checkLife()
    {
        if (currentHealth <= 0)
        {
            Time.timeScale = 0f;
            text.text = timeSinceStart.ToString();
            gameOver.SetActive(true);
        }
    }

    IEnumerator spriteChange()
    {
        spriteR.sprite = hurtSprite;
        yield return new WaitForSeconds(0.2f);
        spriteR.sprite = normalSprite;
    }
}
