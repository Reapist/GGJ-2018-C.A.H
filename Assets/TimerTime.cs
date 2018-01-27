using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TimerTime : MonoBehaviour
{
    private GameObject timerText;
    private GameObject playerA;
    private GameObject playerB;
    private int minute;
    private float seconds;
    private float oldSeconds;
    private float maxObject;
    private float controlledAObject;
    private float controlledBObject;
    private float uncontrolledObject;
    //　最初の時間
    private float startTime;
    void Start()
    {
        timerText = GameObject.Find("TimerText");
        playerA = GameObject.Find("PlayerA");
        playerB = GameObject.Find("PlayerB");

        controlledAObject = 0.0f;
        controlledBObject = 0.0f;
        uncontrolledObject = 0.0f;
        maxObject = 0.0f;
        oldSeconds = 60;
        startTime = 10;
    }
    void Update()
    {
        if(seconds >= 0)
        {
            //　Time.timeでの時間計測
            seconds = startTime - Time.time;
            minute = (int)seconds / 60;
            if ((int)seconds != (int)oldSeconds)
            {
                timerText.GetComponent<Text>().text = minute.ToString("00") + ":" + ((int)(seconds % 60)).ToString("00");
                playerA.GetComponent<Text>().text = " ";
                playerB.GetComponent<Text>().text = " ";

            }
            oldSeconds = seconds;

        }

        controlledAObject = GameObject.FindGameObjectsWithTag("ControlledA").Length;
        controlledBObject = GameObject.FindGameObjectsWithTag("ControlledB").Length;
        uncontrolledObject = GameObject.FindGameObjectsWithTag("Neutral").Length;
        maxObject = controlledAObject + controlledBObject + uncontrolledObject;

        if (seconds < 0)
        {
            float objectA = (controlledAObject / maxObject) * 100;
            float objectB = (controlledBObject / maxObject) * 100;
            playerA.GetComponent<Text>().text= objectA.ToString("00") + "%";
            playerB.GetComponent<Text>().text = objectB.ToString("00") + "%";

        }


    }

}
