using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
          public GameObject image1, image2, image3;
        
    public static int pickup;

    // Start is called before the first frame update
    void Start()
    {
        pickup = 3;
        image1.gameObject.SetActive(false);
        image2.gameObject.SetActive(false);
        image3.gameObject.SetActive(false);        
    }

    // Update is called once per frame
    void Update()
    {
        if(pickup > 3)
            pickup = 3;

            switch (pickup)
            {  case 3:
             image1.gameObject.SetActive(false);
             image2.gameObject.SetActive(false);
             image3.gameObject.SetActive(false);
             break;

              case 2:              
             image1.gameObject.SetActive(true);
             image2.gameObject.SetActive(false);
             image3.gameObject.SetActive(false);
             break;

              case 1:
             image1.gameObject.SetActive(true);
             image2.gameObject.SetActive(true);
             image3.gameObject.SetActive(false);
             break;

             case 0:
             image1.gameObject.SetActive(true);
             image2.gameObject.SetActive(true);
             image3.gameObject.SetActive(true);
             break;

            }

}
}