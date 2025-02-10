using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movement speed, dont forget he 'f' to make it float
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get horizontal and vertical axis input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction based on input
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);

        // Move the player by changing its position
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}
