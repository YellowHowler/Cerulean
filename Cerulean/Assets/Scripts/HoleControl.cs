using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleControl : MonoBehaviour
{
    public string _activeTag = string.Empty;
    bool _isFallIn = false;
    public bool _FallIn
    {
        get{ return _isFallIn; }
    }
    void OnTriggerStay(Collider other)
    {
        Rigidbody rgbd = other.GetComponent<Rigidbody>();  
        Vector3 dir = transform.position - other.transform.position;
        dir.Normalize();

        if(other.CompareTag(_activeTag))
        {
            rgbd.velocity *= 0.9f;
            rgbd.AddForce(dir * rgbd.mass * 20);
            _isFallIn = true;
        }
        else
            rgbd.AddForce(-dir * rgbd.mass * 80);
    }
}
