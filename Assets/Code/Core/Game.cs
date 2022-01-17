using UnityEngine;
using UnityEngine.SceneManagement;

public static class Game
{
    public static Animator m_gameStateMachine;

    public static GameObject FindController(Scene s)
    {
        GameObject[] objs = s.GetRootGameObjects();
        for (int i=0; i < objs.Length; ++i)
        {
            GameObject go = objs[i];
            Controller c = go.GetComponent<Controller>();
            if(c != null)
            {
                return go;
            }
        }
        return null;
    }

    public static bool SceneLoaded(Scene s)
    {
        if (s.isLoaded)
        {
            GameObject go = FindController(s);
            if (go != null)
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
}
