using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{

    [SerializeField]
    private GameObject hinge;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

            hinge.transform.Rotate(0, 90, 0); 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            hinge.transform.Rotate(0, -90, 0); 

    }
}
