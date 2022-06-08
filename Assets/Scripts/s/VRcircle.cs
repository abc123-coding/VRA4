using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class VRcircle : MonoBehaviour
{
    public GameObject inventory;
    public Image imgCircle;
    //public UnityEvent GVRClick;
    public float totalTime = 1.0f; // ������ ���µ� �ɸ��� �ð�
    bool gvrStatus; // ��ƼŬ ��������
    float gvrTimer;

    private void Start()
    {
        inventory = GameObject.Find("Inventory");
        imgCircle = GameObject.Find("Player").transform.Find("Canvas").transform.Find("Image").GetComponent<Image>();
    }

    void Update()
    {
        //��Ŭ �̹��� ä���
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }

        if (gvrTimer > totalTime)
        {
            //GVRClick.Invoke();
            //inventory.GetComponent<Inventory>().PickItem();
        }
    }
    public void GVROn()
    {
        gvrStatus = true;
    }
    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0.2f;
    }
}

