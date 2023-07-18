using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Collider))]
public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent; 

    private Collider colliderObj; //sets the collider as colliderObj

    private void Start()
    {
        //Sets up the components and if the trigger is true or not
        colliderObj = GetComponent<Collider>();
        colliderObj.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {

        triggerEnterEvent.Invoke();
    }
}
