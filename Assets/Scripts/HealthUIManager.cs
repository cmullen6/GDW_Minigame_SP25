using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUIManager : MonoBehaviour
{
    public Slider healthSlider;      // Reference to the health slider
    public Text healthText;          // Reference to the health text (optional)

    // Update the health slider and text UI
    public void UpdateHealthUI(int currentHealth, int maxHealth)
    {
        // Update the slider value
        if (healthSlider != null)
        {
            healthSlider.value = currentHealth;
            healthSlider.maxValue = maxHealth;
        }

        // Update the health text
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth;
        }
    }
}
