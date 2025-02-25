using UnityEngine;

public class GameItem : MonoBehaviour
{
    public ItemBase ItemData;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetData(ItemBase a)
    {
        ItemData = a;
        GetComponent<SpriteRenderer>().sprite = ItemData.ImageUI;

    }
}
