using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorSlide : MonoBehaviour
{
    public Animator _doorAnimator;
    
    void Start()
    {
        _doorAnimator = GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            _doorAnimator.SetTrigger("Open");

        }

    }

    public void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            _doorAnimator.SetTrigger("closed");

        }
    }




}