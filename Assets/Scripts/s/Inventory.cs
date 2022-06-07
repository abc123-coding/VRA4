using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    # region Singleton
    public static Inventory instance;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnSlotCountChange(int val);
    public OnSlotCountChange onSlotCountChange;

    //아이템을 획득하면 슬롯UI에 추가
    public delegate void OnChangeItem();
    public OnChangeItem onChangeItem;

    //획득한 아이템 리스트
    public List<Item>items = new List<Item>();

    private int slotCnt;
    public int SlotCnt
    {
        get => slotCnt;
        set{
            slotCnt = value;
            if (onSlotCountChange != null)
            onSlotCountChange.Invoke(slotCnt);
        }
    }

    void Start()
    {
        SlotCnt = 9; 
    }

    public bool AddItem(Item _item)
    {
        if(items.Count < SlotCnt)
        {
            items.Add(_item);
            if (onChangeItem != null)
            onChangeItem.Invoke(); //아이템 추가에 성공하면 OnChangeItem호출
            return true;
        }
        return false;
    }

    public void RemoveItem(int _index)
    {
        items.RemoveAt(_index);
        onChangeItem.Invoke();
    }

    /*
    //플레이어와 필드아이템이 충돌하면 AddItem을 호출해서 Item 정보를 인자로 넘겨줌
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("FieldItem"))
        {
            FieldItems fieldItems = collision.GetComponent<FieldItems>();
            if (AddItem(fieldItems.GetItem()))
                fieldItems.DestroyItem(); //아이템 획득시 필드에서 제거
        }
    }
    */
    public void PickItem()
    {
        if(Time.timeScale != 0.0f && Input.GetButtonDown("Fire1"))
        {

            FieldItems fieldItems = collision.GetComponent<FieldItems>();
            if (AddItem(fieldItems.GetItem()))
            fieldItems.DestroyItem(); //아이템 획득시 필드에서 제거
            }
        }
    }
}
