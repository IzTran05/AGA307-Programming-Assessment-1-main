using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPad : MonoBehaviour
{
    public GameObject sphere;   //The object we wish to change

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("EnterTrigger");
            //change the spheres colour to green
            sphere.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Leave");
            //set the spheres size back to 1
            sphere.transform.localScale = Vector3.one;
            //Change the spheres colour to yellow
            sphere.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}

