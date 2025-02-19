using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorMOVE : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //print("Something is close to the door.")
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.transform.Translate(new Vector3(0, 2, 0));
        }
            }
    
    private void OnTriggerExit(Collider other)
    {
        //print("Something is away from the door.")
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.transform.Translate(new Vector3(0, -2, 0));
        }
    }
}