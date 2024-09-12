using UnityEngine;
using System.Collections;

public class DraggableBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        draggable = true;
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("Drag");
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
    }
}
