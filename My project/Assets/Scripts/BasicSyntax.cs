using UnityEngine;
using System.Collections;

public class BasicSyntax : MonoBehaviour
{
    void Start(){
        //this line is me writing about my x position of my object

        /*Hi there!
         * I am writing this 
         * */
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f){
            Debug.Log("I believe I can flyyyyyyy!!!!");
        }
    }
}