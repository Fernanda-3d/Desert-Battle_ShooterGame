using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public GameObject boss;
    [SerializeField] GameObject bossDeath1;
    [SerializeField] GameObject bossDeath2;
    [SerializeField] GameObject bossDeath3;
    [SerializeField] GameObject bossDeath4;
    [SerializeField] ParticleSystem explosion1;
    [SerializeField] ParticleSystem explosion2;
    [SerializeField] ParticleSystem explosion3;
    [SerializeField] ParticleSystem explosion4;
     [SerializeField] Transform bossParent;
    
     


    
     void OnParticleCollision(GameObject other) 
    {
         if(other.gameObject.tag == "Player")
         {
             //audioSource.PlayOneShot(hit);
             Boss_LifeController.health_boss -= 1;
             GameObject vfx1 = Instantiate(bossDeath1, transform.position, Quaternion.identity);
             GameObject vfx2 = Instantiate(bossDeath2, transform.position, Quaternion.identity);
             GameObject vfx3 = Instantiate(bossDeath3, transform.position, Quaternion.identity);
             GameObject vfx4 = Instantiate(bossDeath4, transform.position, Quaternion.identity);

             vfx1.transform.parent = bossParent;
             vfx2.transform.parent = bossParent;
             vfx3.transform.parent = bossParent;
             vfx4.transform.parent = bossParent;

             // redUI.SetActive(true);
            // Invoke("RedOff", redDelay);

       if(Boss_LifeController.health_boss < 1)
        {
            
       
        explosion1.Play();
        explosion2.Play();
        explosion3.Play();
        explosion4.Play();
        Destroy(boss);        
     
        }
         }
        
       
    }

    void Gameover()
    {
        SceneManager.LoadScene("GameOver");
    }

   /* void StartCrashSequence()
    {
        audioSource.PlayOneShot(explosion);
        explode1.Play();
        explode2.Play();
        explode3.Play();
        explode4.Play();
        explode5.Play();
        explode6.Play();
        redUI.SetActive(true); 
        }
         */
}
