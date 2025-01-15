using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    
    void Update()
    {
        Ray ray = new Ray(transform.position,transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);
        RaycastHit hit;
        

        if (Physics.Raycast(ray, out hit))
        {
           hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        
    }
}
