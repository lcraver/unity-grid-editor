using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class SelectEvent : MonoBehaviour, IPointerEnterHandler {

    public GameObject editor;
    public int selection;

    public void OnPointerEnter(PointerEventData dataName)
    {
        if (!Input.GetMouseButton(0) && !Input.GetMouseButton(1))
        {
            editor.GetComponent<Snap>().UpdateEventSelection(selection);
        }
    }
}
