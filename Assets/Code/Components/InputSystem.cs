using System;
using System.Collections;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(CloseDisclaimer());
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            Game.m_gameStateMachine.SetTrigger("Cinematic");
        }
    }

    private IEnumerator CloseDisclaimer()
    {
        yield return new WaitForSeconds(3);
        Game.m_gameStateMachine.SetTrigger("Cinematic");
    }
}
