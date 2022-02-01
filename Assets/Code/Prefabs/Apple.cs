using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField]
    private Transform m_appleJoint;
    public bool m_follow = false;

    private void Update()
    {
        if (m_follow)
        {
            this.transform.position = m_appleJoint.transform.position;
        }
    }

    public void AttachApple()
    {
        m_follow = true;
    }

    public void DetachApple()
    {
        m_follow = false;
    }

    public void HideApple()
    {
        this.gameObject.SetActive(false);
    }

    public void ShowApple()
    {
        this.gameObject.SetActive(true);
    }
}
