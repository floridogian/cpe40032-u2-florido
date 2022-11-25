using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Public Variable
    public GameObject[] animalPrefabs;

    // Private Variables
    private float spawnRangeX = 20.0f; // x value indicating the area where the dog object should only respawn.
    private float spawnPosZ = 20.0f; // z value where the dog objects will respawn.
    private float startDelay = 3.0f; // time value for the game's delay in starting to spawn dog objects.
    private float spawnInterval = 2.0f; // interval value for respawning dog objects.

    // Start is called before the first frame update
    void Start()
    {
        // Repeat the spawning of the dog objects
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void SpawnRandomAnimal()
    {
        // Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length); // randomly choose which dog object to respawn
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // randomly spawn dogs within the area of the spawnPos value

        // Spawn dog objects
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }


}
