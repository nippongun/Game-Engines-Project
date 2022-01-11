using UnityEngine;

public class BeginGameState : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Game.m_gameStateMachine.SetTrigger("Disclaimer");
    }
}
