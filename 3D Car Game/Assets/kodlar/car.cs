using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public WheelCollider frontleftwheel, frontrightwheel, rearleftwheel, rearrightwheel;
    // Start is called before the first frame update
    public float motortorque, rotation;
    public Joystick key;
    // Update is called once per frame
    void Update()
    {

        //rearrightwheel.motorTorque = motortorque * Input.GetAxis("Vertical");
        //rearleftwheel.motorTorque = motortorque * Input.GetAxis("Vertical");
        //frontrightwheel.steerAngle = rotation * Input.GetAxis("Horizontal");
        //frontleftwheel.steerAngle = rotation * Input.GetAxis("Horizontal");

        rearrightwheel.motorTorque = motortorque * key.Vertical;
        rearleftwheel.motorTorque = motortorque * key.Vertical;
        frontrightwheel.steerAngle = rotation * key.Horizontal;
        frontleftwheel.steerAngle = rotation * key.Horizontal;

    }
}
