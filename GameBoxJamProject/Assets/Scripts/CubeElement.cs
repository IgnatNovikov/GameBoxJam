using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class CubeElement : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler//, IPointerDownHandler
{
    private BoxCollider _collider;
    private Vector3 _index;
    private MeshRenderer _mesh;

    private bool _tempHighlighted;
    private bool _highlighted;

    private ICubeHelper _helper;

    public void Init(ICubeHelper helper)
    {
        _helper = helper;

        _mesh = GetComponent<MeshRenderer>();
        _collider = GetComponent<BoxCollider>();

        Vector3 position = transform.position;

        _index = position / 2.05f;

        //if (_index.z != -1)
        //{
        //    _collider.enabled = false;
        //}
    }

    public Vector3 GetIndex()
    {
        return _index;
    }

    public void HighLight(bool active)
    {
        _highlighted = active;
        _mesh.material.color = active ? Color.white : Color.black;
    }

    public bool IsHighLighted()
    {
        return _tempHighlighted;
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        _tempHighlighted = true;

        if (_highlighted)
            return;

        _mesh.material.color = Color.white;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        _tempHighlighted = false;

        if (_highlighted)
            return;

        _mesh.material.color = Color.black;
    }
}