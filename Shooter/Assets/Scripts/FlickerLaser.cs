using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLaser : MonoBehaviour
{
    public bool isFlickering = false;

   public ParticleSystem laser;
    public float timeDelay;

    [SerializeField] AudioSource audioSource;



    // Update is called once per frame
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLight());
        }

    }

    IEnumerator FlickeringLight()
    {
        isFlickering = true;
        laser.Play();  
        audioSource.Play();     
        timeDelay = Random.Range(0.5f, 0.8f);
        yield return new WaitForSeconds(timeDelay);
        laser.Stop();
        audioSource.Stop();
        timeDelay = Random.Range(2f, 5f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;


    }
}
