using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{

    public float speed = 3;

    void Update(){

        //If pressed on mouse button
        if (Input.GetMouseButton(0)){       
            transform.RotateAround(transform.position, -Vector3.up, speed * Input.GetAxis("Mouse X"));          //Rotate along the X & Y-axis of the mouse.
            transform.RotateAround(transform.position, transform.right, speed * Input.GetAxis("Mouse Y"));      // Rotate along the Y-axis of the camera. 
        }
        
    }
}
