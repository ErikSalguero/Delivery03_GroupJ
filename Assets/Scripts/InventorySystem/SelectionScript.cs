using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject selection;
    void Start()
    {
        selection.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        selection.SetActive(true);   
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        selection.SetActive(false);
    }
}
