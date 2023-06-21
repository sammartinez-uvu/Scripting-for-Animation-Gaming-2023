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

    //Blaster Vars
    public Transform blaster;
    public GameObject lazerBolt;

    // Update is called once per frame
    void Update()
    {
        //Initialize HorizontalInput to revieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves player left & Right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Boundries
        //Keeps left side
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Keeps right side
        if (transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Blaster Updates
        if (Input.GetKeyDown(KeyCode.Space)) {
            //creates the lazerBolt at the blaster transorm position maintaining obj rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
    }

    //Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other) {

        Destroy(other.gameObject);
    
    }

}
