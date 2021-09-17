using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IENumeratorShield : MonoBehaviour
{
     
     private void Start()
     {
         // StartCoroutine(ActivationRoutine());
     }

     private void Update()
     {
         StartCoroutine(ActivationRoutine());
     }
 
     private IEnumerator ActivationRoutine()
     {        
         //Wait for 5 secs.
         yield return new WaitForSeconds(5f);
 
         //Turn My game object that is set to true(on) to false(off).
         this.gameObject.SetActive(false);

     }
 
}
