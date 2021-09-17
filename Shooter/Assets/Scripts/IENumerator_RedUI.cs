using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IENumerator_RedUI : MonoBehaviour
{
    private void Update()
     {
         StartCoroutine(ActivationRoutine());
     }
 
     private IEnumerator ActivationRoutine()
     {        
         //Wait for 0.5 secs.
         yield return new WaitForSeconds(0.5f);
 
         //Turn My game object that is set to true(on) to false(off).
         this.gameObject.SetActive(false);

     }
 
}
