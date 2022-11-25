using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Private Variable
    private float topBound = 35.0f; // z value for top bound
    private float lowerBound = -4.5f; // z value for lower bound
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the cookie objects once it reached the value of topBound
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        // Destroy the dog objects once it reached the value of lowerBound
        else if (transform.position.z < lowerBound) 
        {
            Debug.Log("Game Over!"); // if the player failed to feed the animal
            Destroy(gameObject);
        }
    }
}
