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

    public void SetInput(InputControl input)
    {
        _input = input;
        //_input.ActionMap.Esc.performed += OnEscTap;
        _input.ActionMap.Direction.started += MoveCube;

        _elements = GetComponentsInChildren<CubeElement>().ToList();

        foreach (CubeElement element in _elements)
        {
            element.Init(this);
        }
    }

    public void HighLight(Vector3 index, bool highlighted)
    {

    }

    public InputControl GetInput()
    {
        return _input;
    }

    private void MoveCube(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();

        CubeElement element = _elements.Find(x => x.IsHighLighted());
        if (element == null)
            return;

        MoveInDirection(direction, element.GetIndex());
    }

    private void MoveInDirection(Vector2 direction, Vector3 index)
    {
        switch (direction.x)
        {
            case -1:
                {
                    List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().y == index.y);
                    CubeElement central = elements.Find(x => x.GetIndex().x == 0 && x.GetIndex().z == 0);

                    if (elements == null || central == null)
                        return;

                    foreach (CubeElement element in elements)
                    {
                        element.gameObject.transform.RotateAround(central.gameObject.transform.position, Vector3.up, 90);

                        element.RefreshIndex();
                    }

                    return;
                    //break;
                }
            case 1:
                {
                    List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().y == index.y);
                    CubeElement central = elements.Find(x => x.GetIndex().x == 0 && x.GetIndex().z == 0);

                    if (elements == null || central == null)
                        return;

                    foreach (CubeElement element in elements)
                    {
                        element.gameObject.transform.RotateAround(central.gameObject.transform.position, Vector3.down, 90);

                        element.RefreshIndex();
                    }

                    return;
                    //break;
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

                    if (elements == null || central == null)
                        return;

                    foreach (CubeElement element in elements)
                    {
                        element.gameObject.transform.RotateAround(central.gameObject.transform.position, Vector3.left, 90);

                        element.RefreshIndex();
                    }

                    return;
                    //break;
                }
            case 1:
                {
                    List<CubeElement> elements = _elements.FindAll(x => x.GetIndex().x == index.x);
                    CubeElement central = elements.Find(x => x.GetIndex().y == 0 && x.GetIndex().z == 0);

                    if (elements == null || central == null)
                        return;

                    foreach (CubeElement element in elements)
                    {
                        element.gameObject.transform.RotateAround(central.gameObject.transform.position, Vector3.right, 90);

                        element.RefreshIndex();
                    }

                    return;
                    //break;
                }
            default:
                {
                    break;
                }
        }
    }
}