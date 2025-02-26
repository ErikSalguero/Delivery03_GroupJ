using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor.EditorTools;


[CreateAssetMenu(fileName = "ShopInventory", menuName = "Scriptable Objects/ShopInventory")]
public class ShopInventory : Inventory
{
    public void PickUp(ICanBePicked item)
    {
        ConsumableItem _item = item as ConsumableItem;
        Debug.Log(_item.name);
        AddItem(item.GetItem());
    }

}
