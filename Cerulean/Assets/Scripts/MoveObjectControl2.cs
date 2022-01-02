using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectControl2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float _movSpeed = 20;
    public float _rotAngle = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mz = Input.GetAxis("Vertical");   
        float mx = Input.GetAxis("Horizontal");
        float ry = Input.GetAxis("Mouse X");
        Vector3 mv = new Vector3(-mx, 0, -mz);

        transform.Translate(mv.normalized * _movSpeed * Time.deltaTime);
        transform.Rotate(0, ry * _rotAngle * Time.deltaTime, 0, Space.World);
    }
}
