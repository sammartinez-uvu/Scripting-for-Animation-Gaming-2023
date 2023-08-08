using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;


    private void OnTriggerEnter(Collider other)
    {

        var tempObj = other.GetComponent<IDContainerBehaviour>(); //otherID is the other object's ID
        if (tempObj == null) //if the tempObj is not null then set the other ID to the tempObj's ID
            return; //ends code


        var otherID = tempObj.idObj;

        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}