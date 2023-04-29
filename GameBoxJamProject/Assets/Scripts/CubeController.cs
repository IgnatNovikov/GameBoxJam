using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Cube _cubePrefab;
    [SerializeField] private Transform _cubeParent;

    private Cube _cube;
    private InputControl _input;

    public void SetInput(InputControl input)
    {
        _input = input;
        Init();
    }

    private void Init()
    {
        if (_cubePrefab == null)
            return;

        _cube = Instantiate(_cubePrefab.gameObject, _cubeParent).GetComponent<Cube>();
        _cube.SetInput(_input);
    }
}
