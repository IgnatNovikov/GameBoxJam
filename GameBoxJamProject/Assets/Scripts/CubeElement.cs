using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeElement : MonoBehaviour
{
    private BoxCollider _collider;
    private Vector3 _index;
    private MeshRenderer _mesh;
    private bool _isHighlighted;

    private ICubeHelper _helper;

    public void Init(ICubeHelper helper)
    {
        _helper = helper;
        
        _mesh = GetComponent<MeshRenderer>();
        _collider = GetComponent<BoxCollider>();

        Vector3 position = transform.position;

        _index = position / 2.05f;

        if (_index.z != -1)
        {
            _collider.enabled = false;
        }
    }

    public Vector3 GetIndex()
    {
        return _index;
    }

    public void HighLight(bool active)
    {
        _isHighlighted = active;
        _mesh.material.color = active ? Color.white : Color.black;
    }

    private void OnMouseEnter()
    {
        if (_isHighlighted)
            return;

        _mesh.material.color = Color.white;
    }

    private void OnMouseExit()
    {
        if (_isHighlighted)
            return;

        _mesh.material.color = Color.black;
    }

    private void OnMouseDown()
    {
        _helper.HighLightRow(_index);
    }
}