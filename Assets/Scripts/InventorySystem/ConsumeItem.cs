using UnityEngine;

public class ConsumeItem : MonoBehaviour, IConsume
{
    public void Use(ConsumableItem item)
    {
        if (item is ItemPotion)
        {
            Debug.Log("Health Potion consumed");
        }
    }
}
