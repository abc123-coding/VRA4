using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    GameObject inventory;

    private void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    private void Update()
    {
        inventory.GetComponent<Inventory>().PickItem();
    }
}
