using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class TimerLabelBehavior : MonoBehaviour
{

    public Text timer;
    public IntData timerData;
    private float interval = 1f;
    private float fractional = 1f;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        timer.text = timerData.time.ToString();
    }

    public void Update()
    {
        fractional -= Time.deltaTime;
        if (fractional < 0)
        {
            timerData.decreaseTimer(1);
            fractional = interval;
            UpdateLabel();
        }
    }
}
