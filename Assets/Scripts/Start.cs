using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene(1);
    }
    public void Update()
    {
        if(Time.timeScale == 0.0f)
        {
            SceneManager.LoadScene(2);
        }
    }
}
