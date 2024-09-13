using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;

    private void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor (ColorID obj)
    {
        if (rendererObj == null)
        {
            rendererObj = GetComponent<SpriteRenderer>();
        }
        rendererObj.color = obj.value;
    }
}
