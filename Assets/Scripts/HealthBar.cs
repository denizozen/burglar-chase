using UnityEngine;
using UnityEngine.UI;

/// <summary>Single heart icon in the health bar; swaps its sprite based on <see cref="HeartStatus"/>.</summary>
public class HealthBar : MonoBehaviour
{
    public Sprite fullHeart, halfHeart, emptyHeart;
    Image heart;

    private void Awake()
    {
        heart = GetComponent<Image>();
    }

    public void SetHeartStatus(HeartStatus status)
    {
        switch (status)
        {
            case HeartStatus.Empty:
                heart.sprite = emptyHeart;
                break;
            case HeartStatus.Half:
                heart.sprite = halfHeart;
                break;
            case HeartStatus.Full:
                heart.sprite = fullHeart;
                break;
        }
    }
}
