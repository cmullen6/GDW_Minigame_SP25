using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 1; // Starting health of the enemy

    // Method to apply damage when hit by a projectile
    public void TakeDamage(int damage)
    {
        health -= damage;

        // Check if the enemy's health is 0 or below, and destroy the enemy if so
        if (health <= 0)
        {
            Die();
        }
    }

    // Method to handle the enemy's death
    private void Die()
    {
        Debug.Log(gameObject.name + " has died!");
        // You can also add an animation, particle effect, or destroy the object
        Destroy(gameObject);
    }
}
