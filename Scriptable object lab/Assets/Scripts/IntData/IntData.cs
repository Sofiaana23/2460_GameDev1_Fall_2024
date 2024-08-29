using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int time;
    private int defaultTime = 100;

    public void decreaseTimer (int value)
    {
        time = Mathf.Max(0, time-value);
    }

    public void setTimer(int value)
    {
        time = value;
    }
}
