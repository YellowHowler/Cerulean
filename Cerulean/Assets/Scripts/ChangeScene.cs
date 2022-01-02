using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void OnGUI()
    {
        if(GUI.Button(new Rect(0, 0, 300, 100), "SampleScene Move"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
