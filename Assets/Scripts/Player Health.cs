using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;    // Max health of the player
    public int currentHealth;      // Current health of the player

    public GameObject gameOverScreen; // Reference to the Game Over UI screen
    public HealthUIManager healthUIManager; // Reference to HealthUIManager

    void Start()
    {
        currentHealth = maxHealth; // Set the initial health
        // Update the health UI at the start
        if (healthUIManager != null)
        {
            healthUIManager.UpdateHealthUI(currentHealth, maxHealth);
        }
    }

    // Call this function when the player takes damage
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Subtract damage from health

        // Ensure health doesn't go below 0
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            GameOver();
        }

        // Update the health UI after taking damage
        if (healthUIManager != null)
        {
            healthUIManager.UpdateHealthUI(currentHealth, maxHealth);
        }
    }

    void GameOver()
    {
        // Activate the Game Over screen
        gameOverScreen.SetActive(true);
    }
}
