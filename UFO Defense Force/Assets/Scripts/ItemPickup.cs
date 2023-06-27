using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private int inventory;
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            inventory++;
            Debug.Log("Current Inventory: " + inventory);
            Destroy(gameObject);
        }
    }

}