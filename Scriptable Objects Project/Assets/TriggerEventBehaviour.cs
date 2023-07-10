using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;


    private void onTriggerEnter(Collider other) {

        triggerEnterEvent.Invoke();
    }
}
