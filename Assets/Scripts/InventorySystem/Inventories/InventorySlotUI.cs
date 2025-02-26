using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image Image;
    public TextMeshProUGUI AmountText;
    public TextMeshProUGUI NameText;

    private Canvas _canvas;
    private GraphicRaycaster _raycaster;
    private Transform _parent;
    private ItemBase _item;
    private InventoryUI _inventory;

    public void Initialize(ItemSlot slot, InventoryUI inventory)
    {
        Image.sprite = slot.Item.ImageUI;
        Image.SetNativeSize();

        AmountText.text = slot.Amount.ToString();
        AmountText.enabled = slot.Amount > 1;
        
        NameText.text = slot.Name.ToString();

        _item = slot.Item;
        _inventory = inventory;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _parent = transform.parent;
        transform.localPosition += new Vector3(eventData.delta.x, eventData.delta.y, 0);

        if (!_canvas)
        {
            _canvas = GetComponentInParent<Canvas>();
            _raycaster = _canvas.GetComponent<GraphicRaycaster>();
        }

        transform.SetParent(_canvas.transform, true);

        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition += new Vector3(eventData.delta.x, eventData.delta.y, 0);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        RaycastHit2D hitData = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

        if (hitData)
        {
            Debug.Log("Drop over object: " + hitData.collider.gameObject.name);
            if (gameObject.tag != hitData.collider.gameObject.tag) 
            {

                var consumer = hitData.collider.GetComponent<ShopInventory>();
                bool consumable = _item is ConsumableItem;
                consumer.PickUp(_item as ICanBePicked);
            }
        }

        transform.SetParent(_parent.transform);
        transform.localPosition = Vector3.zero;
    }
}
