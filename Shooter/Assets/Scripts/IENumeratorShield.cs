using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IENumeratorShield : MonoBehaviour
{
    [SerializeField] GameObject greenUI;
    [SerializeField] ParticleSystem laserBeam1;
    [SerializeField] ParticleSystem laserBeam2;
     [SerializeField] GameObject life;
    [SerializeField] GameObject collider1;
    [SerializeField] GameObject collider2;
    [SerializeField] GameObject collider3;

     
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
         greenUI.SetActive(false);

         life.SetActive(true); 
              collider1.SetActive(true);
              collider2.SetActive(true);
              collider3.SetActive(true);

         //boss laser
        var collisionModule = laserBeam1.GetComponent<ParticleSystem>().collision;
             collisionModule.enabled = true;
        var collisionModule2 = laserBeam2.GetComponent<ParticleSystem>().collision;
             collisionModule2.enabled = true;

     }

   
}
