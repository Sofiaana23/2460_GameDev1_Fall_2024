using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehaviour : MonoBehaviour
{
    public bool canRun = true;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(3);
        Debug.Log("Late Start");

        while (canRun) 
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("Run on Start");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Run");
    }
}
