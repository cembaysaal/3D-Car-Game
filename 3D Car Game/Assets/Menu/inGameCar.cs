using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inGameCar : MonoBehaviour
{
    public int selectedCarIndex;
    public GameObject[] cars;

    void Start()
    {   

        selectedCarIndex = PlayerPrefs.GetInt("SelectedCar",0);
        foreach(GameObject car in cars)
            car.SetActive(false);

        cars[selectedCarIndex].SetActive(true);

    }
}
