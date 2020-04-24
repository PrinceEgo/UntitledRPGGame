using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { private set; get; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public OnCharacterControl characterControl = new OnCharacterControl();

    private void Update()
    {
        characterControl.Invoke(Input.GetAxis("Horizontal"), Input.GetKey(KeyCode.S), Input.GetKeyDown(KeyCode.Space), Input.GetKeyDown(KeyCode.J));
    }

}

public class OnCharacterControl : UnityEvent<float, bool, bool, bool> { }
