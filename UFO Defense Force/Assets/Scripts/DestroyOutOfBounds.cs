using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10f;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1;
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
            Time.timeScale = 0;
        }

    }
}
