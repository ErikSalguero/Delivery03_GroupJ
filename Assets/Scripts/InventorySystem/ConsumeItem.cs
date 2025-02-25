using UnityEngine;

public class ConsumeItem : MonoBehaviour
{
    public void Use( ItemBase item)
    {
        if (item.itemType != itemType.weapon )
        {
            Debug.Log("Item consumed");
        }
    }
}
