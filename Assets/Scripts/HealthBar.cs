using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Sprite fullHeart, halfHeart, emptyHeart;
    Image heart;

    private void Awake()
    {
        heart = GetComponent<Image>();
    }

    public void setHeartStatus(HeartStatus status)
    {
        switch (status)
        {
            case HeartStatus.Empty :
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

public enum HeartStatus
    {
        Full = 2,
        Half = 1,
        Empty = 0
    }

