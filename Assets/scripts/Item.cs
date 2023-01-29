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

    void Start()
    {
        posinicial = transform.position;
        distanciaCorrecta = 150;
    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        float distance = Vector3.Distance(this.transform.position, ItemCorrecto.transform.position);
        if (distance <= distanciaCorrecta)
        {
            this.transform.position = ItemCorrecto.transform.position;
            this.transform.localScale = ItemCorrecto.transform.localScale;
            AudioManager.instance.PlaySound(AudioManager.instance.sfxCorrect);
            GameManager.instance.Correcto();
        }
        else
        {
            this.transform.position = posinicial;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        AudioManager.instance.PlaySound(AudioManager.instance.sfxDrag);
    }
}
