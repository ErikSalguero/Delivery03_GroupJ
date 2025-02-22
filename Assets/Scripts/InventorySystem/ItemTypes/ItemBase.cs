using UnityEngine;

[CreateAssetMenu(fileName = "ItemBase", menuName = "Inventory System/Items/Generic")]
public class ItemBase : ScriptableObject
{
    public string Name;
    public Sprite ImageUI;
    public bool IsStackable;
    public int Cost;
}
