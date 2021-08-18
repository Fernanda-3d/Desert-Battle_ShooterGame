using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject dronePart1;
         
    [SerializeField] ParticleSystem explode1;
    [SerializeField] ParticleSystem explode2;
    [SerializeField] ParticleSystem explode3;
    [SerializeField] ParticleSystem explode4;
    [SerializeField] ParticleSystem explode5;
    [SerializeField] ParticleSystem explode6;
    
    float waitForSeconds = 1f;

   void OnTriggerEnter(Collider other) 
    {
        
             StartCrashSequence();
       
        //Debug.Log($"{this.name} --Triggered by-- {other.gameObject.name}");
        //string interpolation = represented by $ - Doc: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
        
    }

    void OnParticleCollision(GameObject other) 
    {
        StartCrashSequence();
    }

    void StartCrashSequence()
    {
        explode1.Play();
        explode2.Play();
        explode3.Play();
        explode4.Play();
        explode5.Play();
        explode6.Play();
        
        //Disable player controlers- script
        dronePart1.SetActive(false);
        GetComponent<PlayerController>().enabled = false;
        Invoke("ReloadLevel", waitForSeconds);
    }

    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex); // .buildIndex means that the number of the index is the one we're currently on
    }

    // USE PARTICLES AS BULLETS
    // 1 - Ensure particle COLLISION and SEND COLLISION MESSAGE sending are ON * this you find in the particle system itens

    // ---------------------COLLISION ENTER----------------------
    // IN OUR CASE BECAUSE OF THE RAIL WHEN WE COLLIDE WILL NOT STOP THE PLAYER BECAUSE IT'S FOLLOWING THE RAIL
   // WHAT WE HAVE TO DO IS USE TRIGGERS AND MAKE EXPLOSIONS/ SOUNDS / LOST LIFE, etc..
   /* void OnCollisionEnter(Collision other)
    {
       Debug.Log(this.name + "--Collided with--" + other.gameObject.name);
    } */

}
