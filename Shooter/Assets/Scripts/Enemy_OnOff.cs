using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_OnOff : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyOff()
    {
       enemy.SetActive(false);
       // this.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;
        
    }

    public void EnemyOn()
    {
        enemy.SetActive(true);
        
       //  this.GetComponentInChildren<SkinnedMeshRenderer>().enabled = true;
    }
}
