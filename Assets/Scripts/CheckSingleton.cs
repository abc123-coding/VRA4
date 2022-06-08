using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckSingleton : MonoBehaviour
{
    public static CheckSingleton check;

    public static int game;
    public static bool isover;
    public TMP_Text timer;

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
        isover = false;
        count = 0;
        cloth = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(cloth && SceneManager.GetActiveScene().name == "GameScene")
        {
            timer = GameObject.Find("Canvas").transform.Find("timer").GetComponent<TMP_Text>();
            if (float.Parse(timer.text) > 0f && CheckSingleton.count == num_of_item)
            {
                isover = true;
                SceneManager.LoadScene("SuccessScene");
            }
        }
            
    }
}
