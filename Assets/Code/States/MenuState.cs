using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuState : StateMachineBehaviour
{
    private Scene m_scene;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_scene = SceneManager.GetSceneByName("Menu");
        Controller c = Game.FindController(m_scene);
        c.ShowScene();
        c.StartScene();
    }
}
