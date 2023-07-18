using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private Collider colliderObj;

    private void Start() {
        //Sets up the components and if the trigger is true or not
        colliderObj = GetComponent<Collider>();
        colliderObj.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other) {

        triggerEnterEvent.Invoke();
    }
}
