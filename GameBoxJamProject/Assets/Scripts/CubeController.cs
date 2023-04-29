using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Cube _cubePrefab;
    [SerializeField] private Transform _cubeParent;

    private Cube _cube;

    private void Awake()
    {
        if (_cubePrefab == null)
            return;

        _cube = Instantiate(_cubePrefab.gameObject, _cubeParent).GetComponent<Cube>();
    }
}
