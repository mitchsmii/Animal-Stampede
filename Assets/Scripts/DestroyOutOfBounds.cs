using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float bottomBound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroys the projectile if it gets past the top limit
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        // Destroys the animal if it gets past the player, and ends the game
        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }

    void OnTriggerEnter(Collision other)
    {

    }
}
