using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectControl1 : MonoBehaviour
{
    public float _moveSpeed = 5f;
    public float _rotAngle = 180;
    Vector3 _goalPosition;
    Quaternion _goalRotation;

    void Awake()
    {
        _goalPosition = transform.position;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit rHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out rHit, Mathf.Infinity))
            {
                _goalPosition = rHit.point;
                _goalRotation = Quaternion.LookRotation(_goalPosition - transform.position);
            }
        }
        
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _goalRotation, Time.deltaTime * _rotAngle);
        transform.position = Vector3.MoveTowards(transform.position, _goalPosition, Time.deltaTime * _moveSpeed);
    }
}
