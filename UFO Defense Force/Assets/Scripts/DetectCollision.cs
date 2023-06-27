using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {

        Destroy(gameObject); //destroys object
        Destroy(other.gameObject); //destroys the other collided object
    }

}