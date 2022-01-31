using UnityEngine;

public class Controller : MonoBehaviour
{
    private GameObject m_visualObject = null;

    public virtual void Start()
    {
        m_visualObject = GameObject.Find("Visuals");
        HideScene();
    }

    public virtual void StartScene()
    {

    }

    public virtual void StopScene()
    {

    }

    public void HideScene()
    {
        m_visualObject.SetActive(false);
    }

    public void ShowScene()
    {
        m_visualObject.SetActive(true);
    }
}
