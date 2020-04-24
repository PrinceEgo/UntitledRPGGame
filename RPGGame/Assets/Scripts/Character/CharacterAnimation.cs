using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;

    public void DisableController()
    {
        controller.DisableControl = false;
    }

    public void EnableController()
    {
        controller.DisableControl = true;
    }

}
