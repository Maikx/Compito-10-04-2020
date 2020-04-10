using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public float timeLeft = 60.0f; //la variabile del tempo stabilità
    public int cubesClicked = 0;

    void Update()
    {
        Timer();
        MouseClick();
    }

    void Timer()
    //limite di tempo stabilito dal gioco
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            //GameOver
            Time.timeScale = 0.0f;
        }
    }

    void MouseClick()
        {
            if (Input.GetMouseButton(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 10f))
                {
                    GameObject.Find(hit.collider.gameObject.name).SetActive(false);
                    cubesClicked++;
                }
            }
        }

    
}


