using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class CubeElement : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler//, IPointerDownHandler
{
    [SerializeField] private float _offset = 2.05f;

    [SerializeField] private Vector3 _index;
    private MeshRenderer _mesh;

    private bool _tempHighlighted;

    private ICubeHelper _helper;

    public void Init(ICubeHelper helper)
    {
        _helper = helper;

        _mesh = GetComponent<MeshRenderer>();

        Vector3 position = new Vector3(Mathf.Clamp(transform.position.x, -1, 1), Mathf.Clamp(transform.position.y, -1, 1), Mathf.Clamp(transform.position.z, -1, 1));
        Debug.Log(transform.position + " " + position);

        _index = new Vector3((int)position.x, (int)position.y, (int)position.z);
    }

    public void RefreshIndex()
    {
        Vector3 position = new Vector3(Mathf.Clamp(transform.position.x, -1, 1), Mathf.Clamp(transform.position.y, -1, 1), Mathf.Clamp(transform.position.z, -1, 1));

        _index = new Vector3((int)position.x, (int)position.y, (int)position.z);
        _tempHighlighted = false;
    }

    public Vector3 GetIndex()
    {
        return _index;
    }

    public void HighLight(bool active)
    {
        _mesh.material.color = active ? Color.white : Color.black;
    }

    public bool IsHighLighted()
    {
        return _tempHighlighted;
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        _tempHighlighted = true;
        _mesh.material.color = Color.white;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        _tempHighlighted = false;
        _mesh.material.color = Color.black;
    }
}