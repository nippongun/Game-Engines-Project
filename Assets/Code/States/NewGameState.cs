using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameState : StateMachineBehaviour
{
    private Scene m_menuScene;
    private Controller m_menuController = null;

    private Scene m_level;
    private Controller m_levelController = null;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_menuScene = SceneManager.GetSceneByName("Menu");
        m_level = SceneManager.GetSceneByName("Level");

        m_menuController = Game.FindController(m_menuScene);
        m_levelController = Game.FindController(m_level);

        m_menuController.HideScene();
        m_menuController.StopScene();

        m_levelController.StartScene();
    }
}
