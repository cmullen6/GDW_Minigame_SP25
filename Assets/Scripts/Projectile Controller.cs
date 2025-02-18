using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public int damage = 1; // Amount of damage the projectile does
    //public float topBound = 30f;
    // Detect collision with other objects
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object the projectile collided with has an EnemyHealth component
        EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();

        if (enemyHealth != null)
        {
            // If the enemy has the EnemyHealth component, apply damage to it
            enemyHealth.TakeDamage(damage);

            // Destroy the projectile after dealing damage (optional)
            Destroy(gameObject);
        }
    }
    void Update()
    {
        // Check if the projectile's z position exceeds the top bound
       // if (transform.position.z > topBound)
       // {
            // Destroy the projectile when it goes out of bounds
        //    Destroy(gameObject);
      //  }
    }
}
