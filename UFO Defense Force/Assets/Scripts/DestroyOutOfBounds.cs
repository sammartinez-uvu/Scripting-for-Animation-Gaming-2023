using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10f;

    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // Reference Game Manager script on GameManager object
    }

    // Update is called once per frame
    void Update()
    {
        //If out of z top bounds then destroy object
        if (transform.position.z > topBounds) {
            //Destroy this object
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds){
            Debug.Log("Game Over!");
            Destroy(gameObject);
            gameManager.isGameOver = true;
        }

    }
}
