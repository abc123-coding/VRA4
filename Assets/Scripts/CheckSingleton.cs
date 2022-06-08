using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSingleton : MonoBehaviour
{
    public static CheckSingleton check;

    [SerializeField]
    private int num_of_item = 5;    //아이템 개수
    
    public static int count;    //아이템 다 주웠는지 체크
    public static bool cloth;   //옷 입히기 했는지 체크

    private void Awake()
    {
        if(check != null)
        {
            Destroy(gameObject);
            return;
        }
        check = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        cloth = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
