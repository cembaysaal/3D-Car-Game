using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicles : MonoBehaviour
{
    public int currentCarIndex;
    public GameObject[] carModels;
    public int selectedIndex = 0;

    void Start()
    {   

        //currentCarIndex = PlayerPrefs.GetInt("SelectedCar",0);
        currentCarIndex = 0;
        foreach(GameObject car in carModels)
            car.SetActive(false);

        carModels[currentCarIndex].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeNextCar()
    {

        carModels[selectedIndex].SetActive(false);
        carModels[currentCarIndex].SetActive(false);
        currentCarIndex++;
        if(currentCarIndex == carModels.Length) currentCarIndex = 0;

        carModels[currentCarIndex].SetActive(true);
        Debug.Log(currentCarIndex);
    }

    public void changeBackCar()
    {   
        carModels[selectedIndex].SetActive(false);
        carModels[currentCarIndex].SetActive(false);
        currentCarIndex--;
        if(currentCarIndex == -1) currentCarIndex = carModels.Length -1;

        carModels[currentCarIndex].SetActive(true);
        Debug.Log(currentCarIndex);
    }

    public void carSelected(bool carCheck)
    {
        if(carCheck == true){
            PlayerPrefs.SetInt("SelectedCar",currentCarIndex);
            selectedIndex = currentCarIndex;
        }
    }

    public void goBack(bool backCheck)
    {
        if(backCheck == true){
            carModels[currentCarIndex].SetActive(false);
            carModels[selectedIndex].SetActive(true);
        }
    }

}
