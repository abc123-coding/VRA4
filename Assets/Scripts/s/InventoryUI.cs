using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    Inventory inven;

    public GameObject inventoryPanel;
    bool activeInventory = true;

    public Slot[] slots;
    public Transform slotHolder;

    private void Start()
    {
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        //inven.onSlotCountChange += SlotChange;
        inven.onChangeItem += RedrawSlotUI;
        inventoryPanel.SetActive(activeInventory);
    }

    //slotCnt개수만큼만 슬롯 활성화
    private void SlotChange(int val)
    {
        for(int i = 0; i<slots.Length; i++)
        {
            slots[i].slotnum = i;
        }
    }

    /*private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);
        }
    }*/


    //슬롯 초기화&아이템 개수만큼 슬롯 채우기
    void RedrawSlotUI()
    {
        for(int i=0; i<slots.Length; i++)
        {
            slots[i].RemoveSlot();
        }
        for(int i=0; i<inven.items.Count; i++)
        {
            slots[i].item = inven.items[i];
            slots[i].UpdateSlotUI();
        }
    }
}
