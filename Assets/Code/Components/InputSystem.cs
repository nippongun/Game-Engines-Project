using System;
using System.Collections;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Game.OnAcceptAction();
        }
    }   
}
