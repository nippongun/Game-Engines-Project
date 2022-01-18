using System;
using System.Collections;
using UnityEngine;

public class DisclaimerController : Controller
{
    public override void Start()
    {
        base.Start();
        Game.OnAccept += Game_OnAccept; 
    }

    private void Game_OnAccept()
    {
        Game.m_gameStateMachine.SetTrigger("Cinematic");
        StopCoroutine(CloseDisclaimer());
    }

    public override void StartScene()
    {
        StartCoroutine(CloseDisclaimer());
    }

    private IEnumerator CloseDisclaimer()
    {
        yield return new WaitForSeconds(5);
        Game.m_gameStateMachine.SetTrigger("Cinematic");
    }
}
