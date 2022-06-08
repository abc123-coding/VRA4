using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSingleton : MonoBehaviour
{
    public static CheckSingleton check;

    [SerializeField]
    private int num_of_item = 5;    //������ ����
    
    public static int count;    //������ �� �ֿ����� üũ
    public static bool cloth;   //�� ������ �ߴ��� üũ

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
