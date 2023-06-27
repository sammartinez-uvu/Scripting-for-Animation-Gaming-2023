using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //Array to store UFO ships
    private float spawnRangeX = 20f; //Left to right range position
    private float spawnPosZ = 20f; //Starting up and down position

    //Spawn Timing Variables
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;


    void Start() {

        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomUFO() {

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); // Picks random UFO from the array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //spawns indexed UFO from array
    }

}
