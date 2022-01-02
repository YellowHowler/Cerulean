using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    public int durability = 10;
    public GameObject hitEffectFire;
    public GameObject explosionEffect;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Missile"));
        {
            Instantiate(hitEffectFire, collision.gameObject.transform.position, transform.rotation);
            Destroy(collision.gameObject);
            durability--;
        }

        if(durability == 0)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
