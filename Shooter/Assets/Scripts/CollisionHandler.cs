
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
    [SerializeField] GameObject life;
    [SerializeField] GameObject collider1;
    [SerializeField] GameObject collider2;
    [SerializeField] GameObject collider3;
    [SerializeField] ParticleSystem laserBeam1;
    [SerializeField] ParticleSystem laserBeam2;
    
    public Animator transition;

    [SerializeField] ParticleSystem laserBeam4, laserBeam5, laserBeam27, laserBeam28, laserBeam29, laserBeam30, laserBeam31, laserBeam32,
    laserBeam33, laserBeam34, laserBeam35, laserBeam36, laserBeam37, laserBeam38, laserBeam39, laserBeam40, laserBeam41, laserBeam42, laserBeam43,
    laserBeam44, laserBeam45, laserBeam46, laserBeam47, laserBeam67, laserBeam68, laserBeam69; 

    
    

    float redDelay = 0.5f;
    

        
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
             life.SetActive(false);
             collider1.SetActive(false);
             collider2.SetActive(false);
             collider3.SetActive(false);

             //boss laser
        var collisionModule = laserBeam1.GetComponent<ParticleSystem>().collision;
             collisionModule.enabled = false;
        var collisionModule2 = laserBeam2.GetComponent<ParticleSystem>().collision;
             collisionModule2.enabled = false;

            
             // enemies laser
        var collisionModule4 = laserBeam4.GetComponent<ParticleSystem>().collision;
             collisionModule4.enabled = false;
        var collisionModule5 = laserBeam5.GetComponent<ParticleSystem>().collision;
             collisionModule5.enabled = false;
        var collisionModule27 = laserBeam27.GetComponent<ParticleSystem>().collision;
             collisionModule27.enabled = false;
        var collisionModule28 = laserBeam28.GetComponent<ParticleSystem>().collision;
             collisionModule28.enabled = false;
        var collisionModule29 = laserBeam29.GetComponent<ParticleSystem>().collision;
             collisionModule29.enabled = false;
        var collisionModule30 = laserBeam30.GetComponent<ParticleSystem>().collision;
             collisionModule30.enabled = false;
        var collisionModule31 = laserBeam31.GetComponent<ParticleSystem>().collision;
             collisionModule31.enabled = false;
        var collisionModule32 = laserBeam32.GetComponent<ParticleSystem>().collision;
             collisionModule32.enabled = false;
        var collisionModule33 = laserBeam33.GetComponent<ParticleSystem>().collision;
             collisionModule33.enabled = false;
        var collisionModule34 = laserBeam34.GetComponent<ParticleSystem>().collision;
             collisionModule34.enabled = false;
        var collisionModule35 = laserBeam35.GetComponent<ParticleSystem>().collision;
             collisionModule35.enabled = false;
        var collisionModule36 = laserBeam36.GetComponent<ParticleSystem>().collision;
             collisionModule36.enabled = false;
        var collisionModule37 = laserBeam37.GetComponent<ParticleSystem>().collision;
             collisionModule37.enabled = false;
        var collisionModule38 = laserBeam38.GetComponent<ParticleSystem>().collision;
             collisionModule38.enabled = false;
        var collisionModule39 = laserBeam39.GetComponent<ParticleSystem>().collision;
             collisionModule39.enabled = false;
        var collisionModule40 = laserBeam40.GetComponent<ParticleSystem>().collision;
             collisionModule40.enabled = false;
        var collisionModule41 = laserBeam41.GetComponent<ParticleSystem>().collision;
             collisionModule41.enabled = false;
        var collisionModule42 = laserBeam42.GetComponent<ParticleSystem>().collision;
             collisionModule42.enabled = false;
        var collisionModule43 = laserBeam43.GetComponent<ParticleSystem>().collision;
             collisionModule43.enabled = false;
        var collisionModule44 = laserBeam44.GetComponent<ParticleSystem>().collision;
             collisionModule44.enabled = false;
        var collisionModule45 = laserBeam45.GetComponent<ParticleSystem>().collision;
             collisionModule45.enabled = false;
        var collisionModule46 = laserBeam46.GetComponent<ParticleSystem>().collision;
             collisionModule46.enabled = false;
        var collisionModule47 = laserBeam47.GetComponent<ParticleSystem>().collision;
             collisionModule47.enabled = false;
        var collisionModule67 = laserBeam67.GetComponent<ParticleSystem>().collision;
             collisionModule67.enabled = false;
        var collisionModule68 = laserBeam68.GetComponent<ParticleSystem>().collision;
             collisionModule68.enabled = false;
        var collisionModule69 = laserBeam69.GetComponent<ParticleSystem>().collision;
             collisionModule69.enabled = false;

         
             this.gameObject.GetComponent<BoxCollider>().enabled = false;                                           
            
             
         }

          if(other.gameObject.tag == "ShieldOff")
          {
              greenUI.SetActive(false);
              shield.SetActive(false);
              life.SetActive(true); 
              collider1.SetActive(true);
              collider2.SetActive(true);
              collider3.SetActive(true);

              //boss laser
        var collisionModule = laserBeam1.GetComponent<ParticleSystem>().collision;
             collisionModule.enabled = true;
        var collisionModule2 = laserBeam2.GetComponent<ParticleSystem>().collision;
             collisionModule2.enabled = true;

            // enemies laser
        var collisionModule4 = laserBeam4.GetComponent<ParticleSystem>().collision;
             collisionModule4.enabled = true;
        var collisionModule5 = laserBeam5.GetComponent<ParticleSystem>().collision;
             collisionModule5.enabled = true;
        var collisionModule27 = laserBeam27.GetComponent<ParticleSystem>().collision;
             collisionModule27.enabled = true;
        var collisionModule28 = laserBeam28.GetComponent<ParticleSystem>().collision;
             collisionModule28.enabled = true;
        var collisionModule29 = laserBeam29.GetComponent<ParticleSystem>().collision;
             collisionModule29.enabled = true;
        var collisionModule30 = laserBeam30.GetComponent<ParticleSystem>().collision;
             collisionModule30.enabled = true;
        var collisionModule31 = laserBeam31.GetComponent<ParticleSystem>().collision;
             collisionModule31.enabled = true;
        var collisionModule32 = laserBeam32.GetComponent<ParticleSystem>().collision;
             collisionModule32.enabled = true;
        var collisionModule33 = laserBeam33.GetComponent<ParticleSystem>().collision;
             collisionModule33.enabled = true;
        var collisionModule34 = laserBeam34.GetComponent<ParticleSystem>().collision;
             collisionModule34.enabled = true;
        var collisionModule35 = laserBeam35.GetComponent<ParticleSystem>().collision;
             collisionModule35.enabled = true;
        var collisionModule36 = laserBeam36.GetComponent<ParticleSystem>().collision;
             collisionModule36.enabled = true;
        var collisionModule37 = laserBeam37.GetComponent<ParticleSystem>().collision;
             collisionModule37.enabled = true;
        var collisionModule38 = laserBeam38.GetComponent<ParticleSystem>().collision;
             collisionModule38.enabled = true;
        var collisionModule39 = laserBeam39.GetComponent<ParticleSystem>().collision;
             collisionModule39.enabled = true;
        var collisionModule40 = laserBeam40.GetComponent<ParticleSystem>().collision;
             collisionModule40.enabled = true;
        var collisionModule41 = laserBeam41.GetComponent<ParticleSystem>().collision;
             collisionModule41.enabled = true;
        var collisionModule42 = laserBeam42.GetComponent<ParticleSystem>().collision;
             collisionModule42.enabled = true;
        var collisionModule43 = laserBeam43.GetComponent<ParticleSystem>().collision;
             collisionModule43.enabled = true;
        var collisionModule44 = laserBeam44.GetComponent<ParticleSystem>().collision;
             collisionModule44.enabled = true;
        var collisionModule45 = laserBeam45.GetComponent<ParticleSystem>().collision;
             collisionModule45.enabled = true;
        var collisionModule46 = laserBeam46.GetComponent<ParticleSystem>().collision;
             collisionModule46.enabled = true;
        var collisionModule47 = laserBeam47.GetComponent<ParticleSystem>().collision;
             collisionModule47.enabled = true;
        var collisionModule67 = laserBeam67.GetComponent<ParticleSystem>().collision;
             collisionModule67.enabled = true;
        var collisionModule68 = laserBeam68.GetComponent<ParticleSystem>().collision;
             collisionModule68.enabled = true;
        var collisionModule69 = laserBeam69.GetComponent<ParticleSystem>().collision;
             collisionModule69.enabled = true;
         
        this.gameObject.GetComponent<BoxCollider>().enabled = true;  
          }

           if(other.gameObject.tag == "BossLevel")
           {
              StartCoroutine(LoadBoss(SceneManager.GetActiveScene().buildIndex + 1));
              
           }
           
           IEnumerator LoadBoss(int levelIndex)
           {
               transition.SetTrigger("Start");
               yield return new WaitForSeconds(1);
               SceneManager.LoadScene(levelIndex);
           }
        
        //Debug.Log($"{this.name} --Triggered by-- {other.gameObject.name}");
        //string interpolation = represented by $ - Doc: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
        
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
             //Invoke("RedOff", redDelay);

             if(other.gameObject.tag == "Shield")
         {
             
             life.SetActive(false);
             collider1.SetActive(false);
             collider2.SetActive(false);
             collider3.SetActive(false);

             //boss laser
         var collisionModule = laserBeam1.GetComponent<ParticleSystem>().collision;
             collisionModule.enabled = false;
        var collisionModule2 = laserBeam2.GetComponent<ParticleSystem>().collision;
             collisionModule2.enabled = false;

             
             // enemies laser
        var collisionModule4 = laserBeam4.GetComponent<ParticleSystem>().collision;
             collisionModule4.enabled = false;
        var collisionModule5 = laserBeam5.GetComponent<ParticleSystem>().collision;
             collisionModule5.enabled = false;
        var collisionModule27 = laserBeam27.GetComponent<ParticleSystem>().collision;
             collisionModule27.enabled = false;
        var collisionModule28 = laserBeam28.GetComponent<ParticleSystem>().collision;
             collisionModule28.enabled = false;
        var collisionModule29 = laserBeam29.GetComponent<ParticleSystem>().collision;
             collisionModule29.enabled = false;
        var collisionModule30 = laserBeam30.GetComponent<ParticleSystem>().collision;
             collisionModule30.enabled = false;
        var collisionModule31 = laserBeam31.GetComponent<ParticleSystem>().collision;
             collisionModule31.enabled = false;
        var collisionModule32 = laserBeam32.GetComponent<ParticleSystem>().collision;
             collisionModule32.enabled = false;
        var collisionModule33 = laserBeam33.GetComponent<ParticleSystem>().collision;
             collisionModule33.enabled = false;
        var collisionModule34 = laserBeam34.GetComponent<ParticleSystem>().collision;
             collisionModule34.enabled = false;
        var collisionModule35 = laserBeam35.GetComponent<ParticleSystem>().collision;
             collisionModule35.enabled = false;
        var collisionModule36 = laserBeam36.GetComponent<ParticleSystem>().collision;
             collisionModule36.enabled = false;
        var collisionModule37 = laserBeam37.GetComponent<ParticleSystem>().collision;
             collisionModule37.enabled = false;
        var collisionModule38 = laserBeam38.GetComponent<ParticleSystem>().collision;
             collisionModule38.enabled = false;
        var collisionModule39 = laserBeam39.GetComponent<ParticleSystem>().collision;
             collisionModule39.enabled = false;
        var collisionModule40 = laserBeam40.GetComponent<ParticleSystem>().collision;
             collisionModule40.enabled = false;
        var collisionModule41 = laserBeam41.GetComponent<ParticleSystem>().collision;
             collisionModule41.enabled = false;
        var collisionModule42 = laserBeam42.GetComponent<ParticleSystem>().collision;
             collisionModule42.enabled = false;
        var collisionModule43 = laserBeam43.GetComponent<ParticleSystem>().collision;
             collisionModule43.enabled = false;
        var collisionModule44 = laserBeam44.GetComponent<ParticleSystem>().collision;
             collisionModule44.enabled = false;
        var collisionModule45 = laserBeam45.GetComponent<ParticleSystem>().collision;
             collisionModule45.enabled = false;
        var collisionModule46 = laserBeam46.GetComponent<ParticleSystem>().collision;
             collisionModule46.enabled = false;
        var collisionModule47 = laserBeam47.GetComponent<ParticleSystem>().collision;
             collisionModule47.enabled = false;
        var collisionModule67 = laserBeam67.GetComponent<ParticleSystem>().collision;
             collisionModule67.enabled = false;
        var collisionModule68 = laserBeam68.GetComponent<ParticleSystem>().collision;
             collisionModule68.enabled = false;
        var collisionModule69 = laserBeam69.GetComponent<ParticleSystem>().collision;
             collisionModule69.enabled = false;

            
             this.gameObject.GetComponent<BoxCollider>().enabled = false;                                           
             

         }

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
