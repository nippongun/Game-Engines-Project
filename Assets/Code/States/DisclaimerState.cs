using UnityEngine;
using UnityEngine.SceneManagement;

public class DisclaimerState : StateMachineBehaviour
{
    private Scene m_scene;
    private Controller m_controller;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_scene = SceneManager.GetSceneByName("Disclaimer");
        m_controller = Game.FindController(m_scene);
        m_controller.ShowScene();
        m_controller.StartScene();
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_controller.HideScene();
    }
}
