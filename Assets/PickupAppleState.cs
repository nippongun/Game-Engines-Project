using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAppleState : StateMachineBehaviour
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Game.m_boy.ShowApple();
        Game.m_boy.AttachApple();
    }
}
