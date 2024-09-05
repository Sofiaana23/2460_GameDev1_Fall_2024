using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    Color green = new Color(0, 0x4d, 0x10);
    Color yellow = new Color(255, 255, 0);

    float timer = 1;
    public void colorSwap()
    {
        if (timer == 0)
        {
            timer = 1;
            if (GetComponent<SpriteRenderer>().color == green)
            {
                GetComponent<SpriteRenderer>().color = yellow;
            }
            else
            {
                GetComponent<SpriteRenderer>().color = green;
            }
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
