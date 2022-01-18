using UnityEngine;
using UnityEngine.SceneManagement;

public class CinematicState : StateMachineBehaviour
{
    private Scene m_scene;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_scene = SceneManager.GetSceneByName("Cinematic");
        Controller c = Game.FindController(m_scene);
        c.StartScene();
    }
}
