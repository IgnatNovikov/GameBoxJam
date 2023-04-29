using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private CubeController _cubeController;

    private InputControl _input;

    private void Awake()
    {
        _input = new InputControl();

        if (_cubeController != null)
            _cubeController.SetInput(_input);
    }

    private void OnEnable()
    {
        _input.ActionMap.Enable();
    }

    private void OnDisable()
    {
        _input.ActionMap.Disable();
    }
}
