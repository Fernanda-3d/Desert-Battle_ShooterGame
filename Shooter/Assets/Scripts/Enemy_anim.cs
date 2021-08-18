using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_anim : MonoBehaviour
{
    private SkinnedMeshRenderer renderer;
    public float anim_speed;
    private float currentBlendShapeValue = 0; //current value our blend tree has
    private bool isDecreasing = false; //use to check if we're increasing or decreasing

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Wind();
    }

    void Wind()
    {
        currentBlendShapeValue = renderer.GetBlendShapeWeight(0);
        currentBlendShapeValue = renderer.GetBlendShapeWeight(2);
        currentBlendShapeValue = renderer.GetBlendShapeWeight(3);

        //use the bool to not make increase more than 100 and never get back
        if (currentBlendShapeValue >= 100)
             isDecreasing = true;
        else if (currentBlendShapeValue <= 0)
            isDecreasing = false;

        if(!isDecreasing)                
        renderer.SetBlendShapeWeight(0, currentBlendShapeValue + anim_speed * Time.deltaTime);
        // (0) means which one it is in the list // them is how much you want to move
        else
        renderer.SetBlendShapeWeight(0, currentBlendShapeValue - anim_speed * Time.deltaTime);

         if(!isDecreasing)                
        renderer.SetBlendShapeWeight(2, currentBlendShapeValue + anim_speed * Time.deltaTime);
        // (0) means which one it is in the list // them is how much you want to move
        else
        renderer.SetBlendShapeWeight(2, currentBlendShapeValue - anim_speed * Time.deltaTime);

         if(!isDecreasing)                
        renderer.SetBlendShapeWeight(3, currentBlendShapeValue + anim_speed * Time.deltaTime);
        // (0) means which one it is in the list // them is how much you want to move
        else
        renderer.SetBlendShapeWeight(3, currentBlendShapeValue - anim_speed * Time.deltaTime);
    }



}
