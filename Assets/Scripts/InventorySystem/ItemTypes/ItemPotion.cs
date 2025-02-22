using UnityEngine;

[CreateAssetMenu(fileName = "ItemPotion", menuName = "Scriptable Objects/ItemPotion")]
public class ItemPotion : ConsumableItem
{
    public int HealthPoints; 

    public override void Use(IConsume consumer)
    {
        consumer.Use(this);
    }
}
