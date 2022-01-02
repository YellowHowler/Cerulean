using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float passRate = 50f;
    public GameObject ShieldEffect;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Missile" && Random.value > (1 - passRate/100))
        {
            Instantiate(ShieldEffect, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
