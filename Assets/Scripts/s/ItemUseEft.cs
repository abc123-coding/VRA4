using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemEft/Useable/Tool")]
public class ItemUseEft : ItemEffect
{
   public override bool ExecuteRole()
    {
        return true;
    }
}
