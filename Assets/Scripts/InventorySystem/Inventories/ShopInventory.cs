using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopInventory", menuName = "Scriptable Objects/ShopInventory")]
public class ShopInventory : Inventory
{
    public void PickUp(ICanBePicked item)
    {
        AddItem(item.GetItem());
    }

}
