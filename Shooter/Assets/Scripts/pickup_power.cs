using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_power : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    void OnTriggerEnter(Collider other) 
    {
         if(other.gameObject.tag == "Player")
         {  
             audioSource.Play();
              PickUpController.pickup -= 1;
             Destroy(gameObject);
                          
         }              
              
    } 


}

    
