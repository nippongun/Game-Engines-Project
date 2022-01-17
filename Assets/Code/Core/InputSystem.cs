using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(Close);
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            Game.m_gameStateMachine.SetTrigger("Cinematic");
        }
    }
}
