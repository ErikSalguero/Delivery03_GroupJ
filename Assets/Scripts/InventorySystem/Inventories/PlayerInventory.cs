using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInventory", menuName = "Scriptable Objects/PlayerInventory")]
public class PlayerInventory : Inventory
{
 
    public void PickUp(ICanBePicked item)
    {
        AddItem(item.GetItem());
    }
}
