using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rotation;

    private void Start(){
        
        cameraContainer = new GameObject("Camera Container");           //Empty gameobject at 0,0,0
        cameraContainer.transform.position = transform.position;        //Move empty container over to where the camera is.
        transform.SetParent(cameraContainer.transform);                 //Set the camera as the child of the gameobject.

        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro(){

        //Does the system support the Gyroscope?
        if(SystemInfo.supportsGyroscope){
            gyro = Input.gyro;
            gyro.enabled = true;

            //First rotation already set in front of us. 
            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rotation = new Quaternion(0,0,1,0);

            return true;
        }

        //System does not have Gyroscope.
        return false;
    }

    //Update local position of the camera
    private void Update(){
        if (gyroEnabled){
            transform.localRotation =  gyro.attitude * rotation;
        }
    }
}
