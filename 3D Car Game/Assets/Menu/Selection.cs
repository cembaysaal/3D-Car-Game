using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{   
    public GameObject toRotate;
    public GameObject toRotate3;
    public GameObject toRotate5;
    public GameObject toRotate6;
    public GameObject toRotate7;
    public GameObject toRotate8;
    private float rotY;
    public float RotationSpeed;
    public bool ClockwiseRotation;
    void Update()
    {   
        if(ClockwiseRotation==false)
        {
            rotY += Time.deltaTime * RotationSpeed;
        }
        else
        {
            rotY += -Time.deltaTime * RotationSpeed;
        }

        toRotate.transform.rotation = Quaternion.Euler(0,rotY,0);
        toRotate3.transform.rotation = Quaternion.Euler(0,rotY,0);
        toRotate5.transform.rotation = Quaternion.Euler(0,rotY,0);
        toRotate6.transform.rotation = Quaternion.Euler(0,rotY,0);
        toRotate7.transform.rotation = Quaternion.Euler(0,rotY,0);
        toRotate8.transform.rotation = Quaternion.Euler(0,rotY,0);
    }
}
