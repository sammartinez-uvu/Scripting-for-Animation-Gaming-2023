using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GetInputBehaviour : MonoBehaviour
{

    public string currentInput;
    void Update()
    { //void CheckingInput

        if (Input.GetKeyDown(KeyCode.W)){

            Debug.Log("W");
            currentInput = "W";
        }
        
        if (Input.GetKeyDown(KeyCode.A)) {

            Debug.Log("A");
            currentInput = "A";
        }
        
        if (Input.GetKeyDown(KeyCode.S)){

            Debug.Log("S");
            currentInput = "S";
        }
        
        if (Input.GetKeyDown(KeyCode.D)){

            Debug.Log("D");
            currentInput = "D";
        }
    }
}
