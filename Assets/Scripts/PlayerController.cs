using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 0.5f;

    public float xRange = 10f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // sets the left border
        if (transform.position.x < -xRange)
        {
            transform.position = new UnityEngine.Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // sets the right border
        if (transform.position.x > xRange)
        {
            transform.position = new UnityEngine.Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        // allows the player to move left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(UnityEngine.Vector3.right * horizontalInput * speed);


    }
}
