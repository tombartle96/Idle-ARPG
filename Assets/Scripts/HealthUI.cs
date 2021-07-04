using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Health player;
    public Image fill;

    private void OnEnable()
    {
        player.ChangeHealthEvent += ChangeFill;
    }

    public void ChangeFill(int amount)
    {
        fill.fillAmount = (float)player.currentHealth / (float)player.maxHealth;
    }
}
