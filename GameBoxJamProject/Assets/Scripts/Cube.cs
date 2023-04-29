using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public interface ICubeHelper
{
    public void HighLight(Vector3 index, bool highlighted);
    public InputControl GetInput();
}

public class Cube : MonoBehaviour, ICubeHelper
{
    private List<CubeElement> _elements;
    private InputControl _input;

    private bool _row;
    private bool _highlighted;

    public void SetInput(InputControl input)
    {
        _input = input;
        _input.ActionMap.Esc.performed += OnEscTap;
        _input.ActionMap.Direction.started += MoveCube;

        _elements = GetComponentsInChildren<CubeElement>().ToList();

        foreach (CubeElement element in _elements)
        {
            element.Init(this);
        }

        _row = true;
        _highlighted = false;
    }

    public void HighLight(Vector3 index, bool highlighted)
    {
        _highlighted = true;
        if (!highlighted || _row)
            HighLightRow(index);
        else
            HighLightColumn(index);
    }

    public void HighLightRow(Vector3 index)
    {
        ClearHighLight();

        List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().y == index.y);

        foreach (CubeElement element in elements)
        {
            element.HighLight(true);
        }

        _row = false;
    }

    public InputControl GetInput()
    {
        return _input;
    }

    public void HighLightColumn(Vector3 index)
    {
        ClearHighLight();

        List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().x == index.x);

        foreach (CubeElement element in elements)
        {
            element.HighLight(true);
        }

        _row = true;
    }

    private void ClearHighLight()
    {
        foreach (CubeElement element in _elements)
        {
            element.HighLight(false);
        }
    }

    private void OnEscTap(InputAction.CallbackContext context)
    {
        ClearHighLight();
        _highlighted = false;
    }

    private void MoveCube(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();

        CubeElement element = _elements.Find(x => x.IsHighLighted());
        if (element == null)
            return;

        Vector2 index = element.GetIndex();
        MoveInDirection(direction, index);
    }

    private void MoveInDirection(Vector2 direction, Vector2 index)
    {
        switch (direction.x)
        {
            case -1:
                {
                    List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().y == index.y);
                    CubeElement central = elements.Find(x => x.GetIndex().x == 0 && x.GetIndex().z == 0);

                    foreach (CubeElement element in elements)
                    {
                        element.transform.RotateAround(central.transform.position, Vector3.up, 90);
                    }

                    break;
                }
            case 1:
                {
                    List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().y == index.y);
                    CubeElement central = elements.Find(x => x.GetIndex().x == 0 && x.GetIndex().z == 0);

                    foreach (CubeElement element in elements)
                    {
                        element.transform.RotateAround(central.transform.position, Vector3.up, -90);
                    }

                    break;
                }
            default:
                {
                    break;
                }
        }

        switch (direction.y)
        {
            case -1:
                {
                    List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().x == index.x);
                    CubeElement central = elements.Find(x => x.GetIndex().y == 0 && x.GetIndex().z == 0);

                    foreach (CubeElement element in elements)
                    {
                        element.transform.RotateAround(central.transform.position, Vector3.left, 90);
                    }

                    break;
                }
            case 1:
                {
                    List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().x == index.x);
                    CubeElement central = elements.Find(x => x.GetIndex().y == 0 && x.GetIndex().z == 0);

                    foreach (CubeElement element in elements)
                    {
                        element.transform.RotateAround(central.transform.position, Vector3.left, -90);
                    }

                    break;
                }
            default:
                {
                    break;
                }
        }

        ResetIndexes();
    }

    private void ResetIndexes()
    {

    }
}