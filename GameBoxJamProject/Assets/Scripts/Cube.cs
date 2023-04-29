using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public interface ICubeHelper
{
    public void HighLightRow(Vector3 index);
}

public class Cube : MonoBehaviour, ICubeHelper
{
    private List<CubeElement> _elements;

    private void Awake()
    {
        _elements = GetComponentsInChildren<CubeElement>().ToList();

        foreach (CubeElement element in _elements)
        {
            element.Init(this);
        }
    }

    public void HighLightRow(Vector3 index)
    {
        ClearHighLight();

        List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().y == index.y);

        foreach (CubeElement element in elements)
        {
            element.HighLight(true);
        }
    }

    public void HighLightColumn(Vector3 index)
    {
        ClearHighLight();

        List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().z == index.z);

        foreach (CubeElement element in elements)
        {
            element.HighLight(true);
        }
    }

    private void ClearHighLight()
    {
        foreach (CubeElement element in _elements)
        {
            element.HighLight(false);
        }
    }
}
