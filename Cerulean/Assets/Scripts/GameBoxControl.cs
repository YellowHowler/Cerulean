using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoxControl : MonoBehaviour
{
    // Start is called before the first frame update

    const float _gravityPower = 9.81f;
    public float _gravityScale = 1.0f;
    public HoleControl _red;
    public HoleControl _yellow;
    public HoleControl _blue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _dir = Vector3.zero;

        if(Application.isEditor)
        {
            _dir.x = Input.GetAxis("Horizontal");  
            _dir.z = Input.GetAxis("Vertical");
        }
        else
        {
            _dir.x = Input.acceleration.x;  
            _dir.z = Input.acceleration.y;
        }
    
        _dir.y = -1;
        Physics.gravity = _dir.normalized * _gravityPower * _gravityScale;
        
        CheckAll();
    }

    void CheckAll()
    {
        if(_red._FallIn && _yellow._FallIn && _blue._FallIn)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
