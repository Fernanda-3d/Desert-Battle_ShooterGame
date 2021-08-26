using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_power : MonoBehaviour
{
    [SerializeField] GameObject shield;
    [SerializeField] ParticleSystem startshield1;
    [SerializeField] ParticleSystem startshield2;

            

    void OnTriggerEnter(Collider other) 
    {
         if(other.gameObject.tag == "Player")
         {

             Destroy(gameObject);
             shield.SetActive(true);  
             startshield1.Play();
             startshield2.Play();

             PickUpController.pickup -= 1;
             
         }              
              
    }


}

    
