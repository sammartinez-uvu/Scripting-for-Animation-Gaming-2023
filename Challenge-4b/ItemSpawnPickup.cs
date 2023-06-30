using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This code creates a random item that moves down the screen.  If the itme comes in contact with
/// the player then it adds to item collected variables.  If it goes off the screen it will get destroyed
/// </summary>

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] itemSelection; //Array to store items if multiple required
    private float spawnRangeX = 20f; //Left to right range position
    private float spawnPosZ = 20f; //Starting up and down position
    
    
    private float itemcounter = 0; //Item Collection Var

    //Spawn Timing Variables
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    
    
    public float speed = 20.0f; //item movement var

    void Start()
    {

        InvokeRepeating("SpawnItem", startDelay, spawnInterval);
    }


    // Update is called once per frame
    void Update()
    {
        //Moves game object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        
        //If out of z top bounds then destroy object

        if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }

    }

    //Spawing random Item function
    void SpawnItem()
    {

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int itemIndex = Random.Range(0, itemSelection.Length); // Picks random item from the array
        Instantiate(itemSelection[itemIndex], spawnPos, itemSelection[itemIndex].transform.rotation); //spawns indexed item from array (must be put into inspector object)
    }

    //Destroy item when in contact with Player and Collect Item
    void OnTriggerEnter(Collider other)
    {
        itemcounter++;
        Destroy(gameObject); //destroys object
        Console.WriteLine(itemcounter);
    }


}
