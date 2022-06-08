using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleportation : MonoBehaviour
{
    public GameObject player;
    public GameObject info;
    public GameObject panel;    //옷입히기 알림

    private bool isinroom;

    private void Awake()
    {
        isinroom = true;
        panel.SetActive(false);
    }
    private void Update()
    {
        Teleport();
    }
    public void Teleport()
    {
        if (Time.timeScale != 0.0f)
        {
            if (Input.GetButtonDown("Fire1") && isinroom && CheckSingleton.cloth)
            {
                player.transform.position = new Vector3(-1.2f, player.transform.position.y, 0f);
                player.transform.Rotate(Vector3.up * 180);
                isinroom = false;
            }
            else if (Input.GetButtonDown("Fire1") && isinroom && !CheckSingleton.cloth)
            {
                panel.SetActive(true);
                Invoke("OffPanel", 2f);
            }
            else if (Input.GetButtonDown("Fire1") && !isinroom)
            {
                player.transform.position = new Vector3(2f, player.transform.position.y, -6f);
                player.transform.Rotate(Vector3.up * 180);
                isinroom = true;
            }
        }


    }

    public void OffPanel()
    {
        panel.SetActive(false);
    }
    

}
