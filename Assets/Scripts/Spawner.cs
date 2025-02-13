using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Array for the enemies
    public GameObject[] enemies;
    //Interval between enemy spawn
    public float spawnInterval = 2f;
    //THe bounds the enemies can spawn
    public float spawnRange = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //Spawns enemies at these intervals
        InvokeRepeating("Spawn Enemy", 0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       //Spawns enemies from array
       int enemyIndex = Random.Range(0, enemies.Length);
       GameObject enemy = enemies[enemyIndex];
       
        //Determines enemy spawns from left or right
        float spawnX = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(spawnX, transform.position.y, transform.position.z);

        //Spawn them at that position
        Instantiate(enemy, spawnPos, Quaternion.identity);
    }
}
