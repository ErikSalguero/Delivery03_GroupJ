using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "Scriptable Objects/Inventory")]
public class Inventory : ScriptableObject
{
    [SerializeField]
    List<ItemSlot> Slots;
    public int Length => Slots.Count;

    public Action OnInventoryChange;

    public void AddItem(ItemBase item)
    {
        if (Slots == null) Slots = new List<ItemSlot>();

        var slot = GetSlot(item);

        if ((slot != null) && (item.IsStackable))
        {
            slot.AddOne();
        }
        else
        {
            slot = new ItemSlot(item);
            Slots.Add(slot);
        }

        OnInventoryChange?.Invoke();
    }

    public void RemoveItem(ItemBase item)
    {
        if (Slots == null) return;

        var slot = GetSlot(item);

        if (slot != null)
        {
            slot.RemoveOne();
            if (slot.IsEmpty()) RemoveSlot(slot);
        }

        OnInventoryChange?.Invoke();
    }

    private void RemoveSlot(ItemSlot slot)
    {
        Slots.Remove(slot);
    }

    private ItemSlot GetSlot(ItemBase item)
    {
        for (int i = 0; i < Slots.Count; i++)
        {
            if (Slots[i].HasItem(item)) return Slots[i];
        }

        return null;
    }

    public ItemSlot GetSlot(int i)
    {
        return Slots[i];
    }
}
