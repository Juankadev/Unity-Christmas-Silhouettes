using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEditor.Progress;

public class Item : MonoBehaviour, IDragHandler,IEndDragHandler,IBeginDragHandler
{
    Vector3 posinicial;
    [SerializeField] float distanciaCorrecta;
    [SerializeField] GameObject ItemCorrecto;
    bool drag;
    void Start()
    {
        drag = true;
        posinicial = transform.position;
        distanciaCorrecta = 150;
    }
    public void OnDrag(PointerEventData eventData)
    {
        if(drag)
            this.transform.position = Input.mousePosition;
    }

    private bool CalculateDistance()
    {
        float distance = Vector3.Distance(this.transform.position, ItemCorrecto.transform.position);
        if (distance <= distanciaCorrecta)
        {
            drag = false;
            return true;
        }
        return false;
    }
    private void CorrectItem()
    {
        this.transform.position = ItemCorrecto.transform.position;
        this.transform.localScale = ItemCorrecto.transform.localScale;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if (drag)
        {
            if (CalculateDistance())
            {

                CorrectItem();
                AudioManager.instance.PlaySound(AudioManager.instance.sfxCorrect);
                GameManager.instance.Correcto();
            }
            else
            {
                this.transform.position = posinicial;
            }
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {   
        if (drag)
            AudioManager.instance.PlaySound(AudioManager.instance.sfxDrag);
    }
}
