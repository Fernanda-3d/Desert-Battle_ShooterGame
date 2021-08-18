using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject enemyDeath1;
    [SerializeField] GameObject enemyDeath2;
    [SerializeField] GameObject enemyDeath3;
    [SerializeField] GameObject enemyDeath4;

     [SerializeField] Transform parent;

    private void OnParticleCollision(GameObject other) 
    {
        GameObject vfx1 = Instantiate(enemyDeath1, transform.position, Quaternion.identity);
        GameObject vfx2 = Instantiate(enemyDeath2, transform.position, Quaternion.identity);
        GameObject vfx3 = Instantiate(enemyDeath3, transform.position, Quaternion.identity);
        GameObject vfx4 = Instantiate(enemyDeath4, transform.position, Quaternion.identity); // isntantiate on the poit of my enemy

        vfx1.transform.parent = parent;
        vfx2.transform.parent = parent;
        vfx3.transform.parent = parent;
        vfx4.transform.parent = parent;
        
       //Debug.Log($"I'm hit! by {other.gameObject.name}" );
       Destroy(gameObject);
    }
    
}
