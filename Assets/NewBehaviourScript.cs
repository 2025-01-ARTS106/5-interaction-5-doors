using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float xAngle, yAngle, zAngle; 

    private GameObject Door;

    //boolean Open = false;

    private void OnTriggerEnter(Collider other)
    {
        //if(object enters box collider)
        //boolean Open = true;
        //if(boolean = true)
        //Door.transform(x,y,z); move cordinates for door to open.
        //else null?

    }

    private void OnTriggerExit(Collider other)
    {
        //if(object is inside box collider and exits)
        //
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
