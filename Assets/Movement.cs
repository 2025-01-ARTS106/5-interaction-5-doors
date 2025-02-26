using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            door.transform.Translate(new Vector3(0,-4, 0));
        }


}
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
            door.transform.Translate(new Vector3(0,4, 0));
        }
    }
}
