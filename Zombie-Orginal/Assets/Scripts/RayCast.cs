using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 20f ))
        {
            Debug.Log("Hit Somthing");
        }

        else
        {
            Debug.Log("Hit Nothing");
        }
    }   
        
}
