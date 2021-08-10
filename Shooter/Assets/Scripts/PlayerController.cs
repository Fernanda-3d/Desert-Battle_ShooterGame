using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] InputAction movement; //NEW
    [SerializeField] float speed = 10f;
    [SerializeField] float xRange = 12f;
    [SerializeField] float yRange = 8f;

    [SerializeField] float positionPicthFactor = -2f;
    [SerializeField] float controlPitchFactor = -10f;
        

    float xMove;
    float yMove;

    
    void Start()
    {
        
    }

 //ON ENABLE AND ON DISABLE IS USED TO THE NEW INPUT SYSTEM WORK
    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable() 
    {
        movement.Disable();
    }

    // Update is called once per frame
    void Update()
    {
      Move();
      Rotate();

    }

 void Move()
 {
   // NEW INPUT SYSTEM
    xMove = movement.ReadValue<Vector2>().x;
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

     float yaw =  0f;
     float roll =  0f;
                                                  //Rool(Z), Pitch(X) and Yaw(Y) - 
     transform.localRotation = Quaternion.Euler(pitch, yaw, roll); //Quaternion.Euler(x, y, z)** this is the same as (picth, yall, roll)

 }



}
