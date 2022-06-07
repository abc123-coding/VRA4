using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    //다른 클래스에서 접근가능해야함
    public static ItemDatabase instance;
    private void Awake()
    {
        instance = this;
    }

    //아이템 리스트
    public List<Item> itemDB = new List<Item>();
    //[Space(9)]
    //public GameObject fieldItemPrefab; //필드아이템 복제(생성) 위해
    //public Vector3[] pos; //아이템 생성될 위치

    /*
    private void Start()
    {
        for(int i = 0; i<4; i++)
        {
            GameObject go = Instantiate(fieldItemPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            go.GetComponent<FieldItems>().SetItem(itemDB[Random.Range(0, 5)]); //Random.Range(0,5)
        }
    }
    */
}
