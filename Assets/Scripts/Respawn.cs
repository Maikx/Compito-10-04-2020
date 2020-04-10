using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    Gamemanager gm;
    public GameObject Block1;
    public GameObject Block2;
    public GameObject Block3;
    public GameObject Block4;
    public GameObject Block5;
    public GameObject Block6;
    public GameObject Block7;
    public GameObject Block8;
    public GameObject Block9;
    public GameObject Block10;
    public GameObject Block11;
    public GameObject Block12;
    public GameObject Block13;
    public GameObject Block14;
    public GameObject Block15;
    public GameObject Block16;
    public GameObject Block17;
    public GameObject Block18;
    public GameObject Block19;
    public GameObject Block20;
    public GameObject Block21;
    public GameObject Block22;
    public GameObject Block23;
    public GameObject Block24;
    public GameObject Block25;
    public GameObject Block26;
    public GameObject Block27;
    public GameObject Block28;
    public GameObject Block29;
    public GameObject Block30;
    public GameObject Block31;
    public GameObject Block32;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Cube") == null)
        {
            Block1.SetActive(true);
            Block2.SetActive(true);
            Block3.SetActive(true);
            Block4.SetActive(true);
            Block5.SetActive(true);
            Block6.SetActive(true);
            Block7.SetActive(true);
            Block8.SetActive(true);
            Block9.SetActive(true);
            Block10.SetActive(true);
            Block11.SetActive(true);
            Block12.SetActive(true);
            Block13.SetActive(true);
            Block14.SetActive(true);
            Block15.SetActive(true);
            Block16.SetActive(true);
            Block17.SetActive(true);
            Block18.SetActive(true);
            Block19.SetActive(true);
            Block20.SetActive(true);
            Block21.SetActive(true);
            Block22.SetActive(true);
            Block23.SetActive(true);
            Block24.SetActive(true);
            Block25.SetActive(true);
            Block26.SetActive(true);
            Block27.SetActive(true);
            Block28.SetActive(true);
            Block29.SetActive(true);
            Block30.SetActive(true);
            Block31.SetActive(true);
            Block32.SetActive(true);
        }
    }
}
