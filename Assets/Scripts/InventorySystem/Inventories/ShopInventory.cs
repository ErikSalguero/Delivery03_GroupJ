using UnityEngine;

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
