using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float lifeTime = 4;
    public float force = 100;
    Rigidbody body;

    float checkTime = 0;

    void Awake()
    {
        Vector3 forward = transform.rotation * Vector3.forward;
        body = this.GetComponent<Rigidbody>();
        body.AddForce(-forward * force);
        Destroy(gameObject, lifeTime);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
