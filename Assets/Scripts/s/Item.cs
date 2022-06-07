using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipment,
    Supplies,
    Etc
}

[System.Serializable]
public class Item
{
    public ItemType itemType;
    public string itemName;
    public Sprite itemImage;
    public GameObject itemPrefab;

    public List<ItemEffect> efts;

    public bool Use()
    {
        bool isUsed = false;
        foreach(ItemEffect eft in efts) //반복문을 돌려서 efts의 ExecuteRole 실행
        {
            isUsed = eft.ExecuteRole();
        }

        return isUsed; //아이템 사용 성공여부 반환
    }
}
