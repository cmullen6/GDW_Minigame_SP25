using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damageAmount = 10; // The amount of damage the enemy does

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object that collided is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get the PlayerHealth component and call TakeDamage method
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }
        }
    }
}


