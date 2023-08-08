using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CompareInputBehaviour : MonoBehaviour
{
    public ArrowID keyToPress;
    private ArrowID keyPressed;
    public UnityEvent inputCorrect, inputIncorrect, inputInvalid;

    void Update() { //void CheckingInput

        if(keyPressed == keyToPress){

            Debug.Log("Same Key");
            
        }else {
            Debug.Log("Different Key");
        }

    }
}
