using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    CharacterController2D controller = null;

    private void Start()
    {
        controller = GetComponent<CharacterController2D>();

        InputManager.Instance.characterControl.AddListener(HandleCharacterControl);
    }

    private void HandleCharacterControl(float horizontal, bool crouch, bool jump, bool attack)
    {
        controller.Move(horizontal, crouch, jump, attack);
    }
}
