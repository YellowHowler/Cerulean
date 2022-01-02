using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherControl : MonoBehaviour
{
    float launchDelay = 50;
    public GameObject prefabMissileObjFire;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && launchDelay <= 0)
        {
            Instantiate(prefabMissileObjFire, transform.position, transform.rotation);
            launchDelay = 50;
        }

        launchDelay -= 1;
    }
}
