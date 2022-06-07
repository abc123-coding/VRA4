using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerUpHandler
{
    public int slotnum;
    public Item item;
    public Image itemIcon;

    public void UpdateSlotUI()
    {
        itemIcon.sprite = item.itemImage;
        itemIcon.gameObject.SetActive(true);
    }
    
    public void RemoveSlot()
    {
        item = null;
        itemIcon.gameObject.SetActive(false);
    }

    //reticle로 변경
    public void OnPointerUp(PointerEventData eventData)
    {
        bool isUse = item.Use();
        if(isUse) //아이템 사용에 성공하면 슬롯에서 삭제
        {
            Inventory.instance.RemoveItem(slotnum);
        }
    }
}
