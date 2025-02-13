using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Enemy movement speed
    public float moveSpeed = 5f;
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        //Find the player
        playerTransform = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null)
        {
            //move towards the player
            Vector3 direction = playerTransform.position - transform.position;
            direction.y = 0;

            //Makes the movespeed consistant 
            Vector3 moveDirection = direction.normalized;

            //moves
            transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, moveSpeed * Time.deltaTime);
        }
    }
}
