using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_protect : MonoBehaviour
{

    float shieldDelay = 15f;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        Invoke("ShieldDelay", shieldDelay);
    }

    void ShieldDelay()
    {
        this.gameObject.SetActive(false);
    }

    

   
}
