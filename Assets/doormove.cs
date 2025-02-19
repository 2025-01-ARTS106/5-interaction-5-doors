using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doormove : MonoBehaviour
{

    [SerializeField]
    private GameObject hinge;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

           hinge.transform.Rotate(0,-292,0) 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            hinge.transform.Rotate(0, -360, 0)

    }
}
