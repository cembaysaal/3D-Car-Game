using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float  MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;
    public GameObject gameOverPanel;
    public static float RawTime;

    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        //MilliDisplay = MilliCount.ToString("F1");
        MilliDisplay = String.Format("{0:0.0}", Math.Round(MilliCount, 1).ToString());
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;

        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
        }
        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = "" + SecondCount + ".";
        }
        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }
        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }
        if (MinuteCount == 6)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
