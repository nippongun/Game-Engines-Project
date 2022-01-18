using UnityEngine;
using UnityEngine.SceneManagement;

public static class Game
{
    public static Animator m_gameStateMachine;

    public delegate void OnAcceptHandler();
    public static event OnAcceptHandler OnAccept;

    public static Controller FindController(Scene s)
    {
        GameObject[] objs = s.GetRootGameObjects();
        for (int i=0; i < objs.Length; ++i)
        {
            GameObject go = objs[i];
            Controller c = go.GetComponent<Controller>();
            if(c != null)
            {
                return c;
            }
        }
        return null;
    }

    public static bool SceneLoaded(Scene s)
    {
        if (s.isLoaded)
        {
            Controller c = FindController(s);
            if (c != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }

    public static void OnAcceptAction()
    {
        OnAccept?.Invoke();
    }
}
