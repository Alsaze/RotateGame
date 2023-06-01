using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeInputHandler : MonoBehaviour,  IDragHandler, IEndDragHandler
{
    [SerializeField] private LabirintRotation _labirint;

    private bool _isRotating = false;
    private float _direction;

    public void OnDrag(PointerEventData eventData)
    {
        _isRotating = true;

        _direction = Mathf.Clamp(eventData.delta.x, -1, 1);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _isRotating = false;
    }

    private void Update() 
    {
        if(_isRotating)
        {
            _labirint.ApplySwipeRotation(_direction);
        }
    }
}
