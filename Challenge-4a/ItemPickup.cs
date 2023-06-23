using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    //Initialize movement and inventory vars
    public float speed = -5.0f;
    private int inventory;

    //Mono if other object tag is player then add 1 to inventory, show how much in the inventory through a Dbug and destroys the item
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            inventory++;
            Debug.Log("Current Inventory: " + inventory);
            Destroy(gameObject);
        }
    }

}
 // Update is called once per frame
    void Update()
    {
        //Moves game object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }