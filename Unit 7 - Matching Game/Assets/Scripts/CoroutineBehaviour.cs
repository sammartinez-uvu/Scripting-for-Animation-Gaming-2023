using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{

    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;


    public bool canRun;
    public IntData counterNum;
    
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    public bool CanRun { 
    
        get => canRun; set => canRun = value;
    }



    private void Start() {

        wffuObj = new WaitForFixedUpdate();
        wfsObj = new WaitForSeconds(seconds);
        startEvent.Invoke();

    }



    public void StartCounting() {

        StartCoroutine(Counting());
    }

    private IEnumerator Counting() {

        startCountEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0) {

            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;

        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse() { 
    
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse() {

        while (canRun) {

            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }    
    }
}
