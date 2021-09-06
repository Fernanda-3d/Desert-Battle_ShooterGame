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
    [SerializeField] GameObject redUI;
    [SerializeField] GameObject greenUI;

     [SerializeField] ParticleSystem startshield1;
    [SerializeField] ParticleSystem startshield2;    
     [SerializeField] GameObject shield;

     [SerializeField] AudioSource audioSource;
     [SerializeField] AudioClip hit;
    [SerializeField] AudioClip explosion;
    
    

    float redDelay = 0.5f;
    float greenDelay = 3f;

        
    float waitForSeconds = 1f;

    void Start()
    {
        redUI.SetActive(false);
        
    }

   void OnTriggerEnter(Collider other) 
    {
         if(other.gameObject.tag == "Enemy")
         {
          audioSource.PlayOneShot(hit);
         LifeController.health -= 1;
        redUI.SetActive(true);
        Invoke("RedOff", redDelay);

         if(LifeController.health < 1)
        {
         StartCrashSequence();
        }

         }

         if(other.gameObject.tag == "Pickup")
         {
             shield.SetActive(true);  
             greenUI.SetActive(true);                       
             Invoke("GreenOff", greenDelay);

         }
        
        //Debug.Log($"{this.name} --Triggered by-- {other.gameObject.name}");
        //string interpolation = represented by $ - Doc: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
        
    }

    void GreenOff()
    {
        greenUI.SetActive(false);
        shield.SetActive(false);
    }
    void RedOff()
    {
        redUI.SetActive(false);
    }

    void OnParticleCollision(GameObject other) 
    {
         if(other.gameObject.tag == "Enemy")
         {
             audioSource.PlayOneShot(hit);
             LifeController.health -= 1;
              redUI.SetActive(true);
             Invoke("RedOff", redDelay);

        if(LifeController.health < 1)
        {
         StartCrashSequence();
        }
         }
        
       
    }

    void StartCrashSequence()
    {
        audioSource.PlayOneShot(explosion);
        explode1.Play();
        explode2.Play();
        explode3.Play();
        explode4.Play();
        explode5.Play();
        explode6.Play();
        redUI.SetActive(true);
        
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
