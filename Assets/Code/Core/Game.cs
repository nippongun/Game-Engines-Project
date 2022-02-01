using UnityEngine;
using UnityEngine.SceneManagement;

public static class Game
{
    public static Animator m_gameStateMachine;
    public static Boy m_boy;

    public delegate void OnAcceptHandler();
    public static event OnAcceptHandler OnAccept;

    public delegate void OnUpHandler();
    public static event OnUpHandler OnUp;

    public delegate void OnUpReleaseHandler();
    public static event OnUpReleaseHandler OnUpRelease;

    public delegate void OnDownHandler();
    public static event OnDownHandler OnDown;

    public delegate void OnDownReleaseHandler();
    public static event OnDownReleaseHandler OnDownRelease;

    public delegate void OnLeftHandler();
    public static event OnLeftHandler OnLeft;

    public delegate void OnRightHandler();
    public static event OnRightHandler OnRight;

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

    public static void OnDownAction()
    {
        OnDown?.Invoke();
    }

    public static void OnDownReleaseAction()
    {
        OnDownRelease?.Invoke();
    }

    public static void OnUpAction()
    {
        OnUp?.Invoke();
    }

    public static void OnUpReleaseAction()
    {
        OnUpRelease?.Invoke();
    }

    public static void OnLeftAction()
    {
        OnLeft?.Invoke();
    }

    public static void OnRightAction()
    {
        OnRight?.Invoke();
    }
}
