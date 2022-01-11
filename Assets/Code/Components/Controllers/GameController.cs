using UnityEngine;

public class GameController : Controller
{
    public void Start()
    {
        Animator anim = this.GetComponent<Animator>();
        Game.m_gameStateMachine = anim;
    }
}