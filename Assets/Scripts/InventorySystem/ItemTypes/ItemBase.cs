using UnityEngine;


public enum itemType 
{ 
    weapon,
    potion,
    food
}
[CreateAssetMenu(fileName = "ItemBase", menuName = "Inventory System/Items/Generic")]
public class ItemBase : ScriptableObject
{
    public string Name;
    public itemType itemType;
    public Sprite ImageUI;
    public bool IsStackable;
    public int Cost;
    public int restoreLife;
}
