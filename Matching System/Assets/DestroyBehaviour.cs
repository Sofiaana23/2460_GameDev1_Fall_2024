using System.Collections;
using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
    public float seconds = 1;
    public WaitForSeconds wfsObj;
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return wfsObj;
        Destroy(gameObject);
    }

    
}
