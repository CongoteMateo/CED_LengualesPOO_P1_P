using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour { 

    private float health;
    private float maxHealth;

    private Image healthBarImage;

    private void Start()
    {
        health = maxHealth;
    }

    public void AddHealth(float amount)
    {
        health += amount;
        if(health > maxHealth)
        {
            health = maxHealth;
        }
        else if(health < 0)
        {
            health = 0;
        }

        UpdateHealthUI();
    }
    // (0,max) -> (0, 1)
    private void UpdateHealthUI()
    {
        healthBarImage.fillAmount = (1 / maxHealth) * health;
    }
}
