using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header ("New Input System Settings")]
    [SerializeField] InputAction movement; //NEW
    [SerializeField] InputAction fire; //NEW

    [Header ("General Setup Settings")]
    [Tooltip("How fast ship moves up and down based on player input")]
    [SerializeField] float speed = 10f;
    [SerializeField] float xRange = 12f;
    [SerializeField] float yRange = 8f;

    [Header ("Laser Gun Array")]
    [Tooltip("Add all player lasers here")]
    [SerializeField] GameObject[] lasers;

    [Header ("Screen position based tuning")]
    [SerializeField] float positionPicthFactor = -2f;
    [SerializeField] float positionYawFactor = -1f;
    
    [Header ("Screen input based tuning")]
    [SerializeField] float controlPitchFactor = -10f;
    [SerializeField] float controlRollFactor = -15f;
        
    [SerializeField] ParticleSystem shoot1;
    [SerializeField] ParticleSystem shoot2;

    float xMove;
    float yMove;

    
    void Start()
    {
        
    }

 //ON ENABLE AND ON DISABLE IS USED TO THE NEW INPUT SYSTEM WORK
    private void OnEnable()
    {
        movement.Enable();
        fire.Enable();
    }

    private void OnDisable() 
    {
        movement.Disable();
        fire.Disable();
    }

    // Update is called once per frame
    void Update()
    {
      Move();
      Rotate();
      Fire();
    }

 void Move()
 { 
   // NEW INPUT SYSTEM
    xMove = movement.ReadValue<Vector2>().x; //this movement is the variable created  as InputAction
    yMove = movement.ReadValue<Vector2>().y;

    float xOffset = xMove * Time.deltaTime * speed; //My moving position = to my input, so them is changed as much as I press * the velocity I want to
    float rawXPos = transform.localPosition.x + xOffset; //TO MOVE - where you are + how much you want to move
    float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange); //define ramdonly the clamp between the variable value

    float yOffset = yMove * Time.deltaTime * speed; //speed - maybe I can change the velocity creating a new variable
    float rawYPos = transform.localPosition.y + yOffset; 
    float clampedYPos = Mathf.Clamp(rawYPos, -yRange, yRange); //define ramdonly the clamp between the variable value
    
    transform.localPosition = new Vector3 (clampedXPos, clampedYPos, transform.localPosition.z);

    //mathf.Clamp() is used to constrain movement - don't go more than we want to the player go. We'll need to crate min
    //and max variables, can create a Range as well
     
        // OLD INPUT SYSTEM 
       /* float horizontalMove = Input.GetAxis ("Horizontal");
        Debug.Log(horizontalMove);

        float verticalMove = Input.GetAxis ("Vertical");
        Debug.Log(verticalMove); */
      
 }

 void Rotate()
 {
     float pitchPosition = transform.localPosition.y * positionPicthFactor;
     float picthControl = yMove * controlPitchFactor;

     float pitch = pitchPosition + picthControl; // SENTENCE1 |  this is the same as the sentece bellow but organized with the floats up,
                                                 //just to make it more readable
     //float pitch =  transform.localPosition.y * positionPicthFactor + yMove * controlPitchFactor;  //SENTENCE2
     float yaw = transform.localPosition.x * positionYawFactor;    
     float roll = xMove * controlRollFactor;
                                                                    //Pitch(X), Yaw(Y) Rool(Z)  - 
     transform.localRotation = Quaternion.Euler(pitch, yaw, roll); //Quaternion.Euler(x, y, z)** this is the same as (picth, yall, roll)

 }

 void Fire()
 {
     //OLD INPIT SYSTEM  - uses bool
     /*
     if (Input.GetButton("Fire1")) -- this "Fire1" is already set up in the project manager
     {
        Debug.Log("I'm shooting");        
     }
     else
     {
         Debug.Log("I'm not shooting"); 
     }
     */

     //NEW INPIT SYSTEM  - uses float

     if(fire.ReadValue<float>() > 0.5)
     {
         LaserOn(true);
        shoot1.Play();
        shoot2.Play();
         Debug.Log("I'm shooting");
     }
     else
     {
         LaserOn(false);
         Debug.Log("I'm not shooting"); 
     }

     void LaserOn(bool isActive)
     {
         foreach (GameObject laser in lasers)
         {
             var emissionModule = laser.GetComponent<ParticleSystem>().emission;
             emissionModule.enabled = isActive;
         }
         
     }

    
     //for each loop - control flow statement for traversing a collection, its a way of saying "do this to everthing in our collection"
     // how to write --  foreach (ObjectType iten in things) - the object can be a game object or intager or string
     //  how to activate and deactivate game object -- gameObjectName.SetActive(true) / gameObjectName.SetActive(false)


 }



}
