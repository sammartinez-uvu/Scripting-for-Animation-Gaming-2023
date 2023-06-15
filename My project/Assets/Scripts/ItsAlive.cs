using UnityEngine;
using System.Collections;

public class ItsAlive : MonoBehaviour
{
    public string myName;

    // Use this for initialization
    void Start(){
        Debug.Log("I am alive " + myName);
    }
}