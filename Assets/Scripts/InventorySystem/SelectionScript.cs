using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject selection;
    void Start()
    {
        selection.SetActive(false);
    }

    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData)
    {
        selection.SetActive(true);   
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        selection.SetActive(false);
    }
}
