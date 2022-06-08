using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOVer : MonoBehaviour
{
    GameObject singleton;
    // Start is called before the first frame update
    void Start()
    {
        singleton = GameObject.Find("info");
        Destroy(singleton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
