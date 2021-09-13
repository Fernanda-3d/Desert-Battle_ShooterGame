using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStopped : MonoBehaviour
{
    public GameObject player;
    public GameObject laser1, laser2, laser3;
     
     public void Stopped()
     {
         player.GetComponent<PlayerController>().enabled = false;
         player.GetComponent<CollisionHandler>().enabled = false;
         laser1.SetActive(false);
         laser2.SetActive(false);
         laser3.SetActive(false);

     }

     public void Training()
     {
         player.GetComponent<PlayerController>().enabled = true;
         player.GetComponent<CollisionHandler>().enabled = true;
        laser1.SetActive(true);
         laser2.SetActive(true);
         laser3.SetActive(true);

     }
}
