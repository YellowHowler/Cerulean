using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    float x;
    float y;
    float z;
    float s;
    float speed;
    Vector3 _goalPosition;

    void setGoal()
    {
        x = Random.Range(-3.5f, 3.5f);
        y = Random.Range(5,7);
        z = Random.Range(7, 18);
        s = Random.Range(0.02f, 0.1f);
        speed = Random.Range(0.3f, 1.5f);
        transform.position = new Vector3(x, y, z);
        transform.localScale = new Vector3(s, s, s);
        _goalPosition = new Vector3(x, y, Random.Range(-14, -7));
    }
    void Awake()
    {
        setGoal();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position - _goalPosition).magnitude > 0.1f)
            transform.position = Vector3.MoveTowards(transform.position, _goalPosition, Time.deltaTime * speed);
        else
            setGoal();
    }
}
