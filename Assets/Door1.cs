using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public GameObject DoorObject;
    public float degreesPerSecond = 90f;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine("RotateDoor");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine("RotateDoorReverse");
        }
    }
    private IEnumerator RotateDoor()
    {
        float degreesRotated = 0f;
            while (degreesRotated < 90)
        {

            DoorObject.transform.Rotate(new Vector3(0, 90, 0) / degreesPerSecond * Time.deltaTime);
            degreesRotated = degreesRotated + (90 / degreesPerSecond * Time.deltaTime);
            yield return null;
        }
    }
    private IEnumerator RotateDoorReverse()
    {
        float degreesRotated = 90f;
        while (degreesRotated > 0)
        {

            DoorObject.transform.Rotate(new Vector3(0, -90, 0) / degreesPerSecond * Time.deltaTime);
            degreesRotated = degreesRotated + (-90 / degreesPerSecond * Time.deltaTime);
            yield return null;
        }

    }



}
