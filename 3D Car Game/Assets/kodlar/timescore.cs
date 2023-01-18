using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timescore : MonoBehaviour
{
    public float zaman;
    public Text zaman_T;
    // Start is called before the first frame update
    void Start()
    {
        zaman = 5;
        zaman_T.text = "" + (int)zaman;
    }

    // Update is called once per frame
    void Update()
    {
        zaman -= Time.deltaTime;
        zaman_T.text = "" + (int)zaman;
        if (zaman >= 0)
        {
            zaman = 5;
            Time.timeScale = 0;
        }
        else if (zaman <= 0)
        {
            Time.timeScale = 1;
        }
    }
}