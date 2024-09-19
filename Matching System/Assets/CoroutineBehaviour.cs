using System.Collections;
using System.Collections.Generic;
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

    private void Start()
    {
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(routine: Counting());
    }
    private IEnumerator Counting()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();

        startCountEvent.Invoke();
        while (counterNum.value > 0) 
        {
            Debug.Log(counterNum);
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
            
           
        }
        endCountEvent.Invoke();
        
    }

    public void StartRepeatUntilFalse() 
    {
        canRun = true;
        StartCoroutine(routine: RepeatUntilFalse());
    }
    private IEnumerator RepeatUntilFalse() 
    {
        while (canRun) 
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }
    }
}