using UnityEngine;

public class ConsumeItem : MonoBehaviour
{

    ItemBase item;
    public void Use( ItemBase item)
    {
        if (item.itemType != itemType.weapon )
        {
            Debug.Log("Item consumed");
        }

    }
}
