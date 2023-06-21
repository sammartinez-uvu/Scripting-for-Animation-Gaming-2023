using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement
    public float horizontalInput;
    public float speed;

    //How far the player can go before getting stopped
    public float xRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Initialize HorizontalInput to revieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves player left & Right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //

        //Keeps left side
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Keeps right side
        if (transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
