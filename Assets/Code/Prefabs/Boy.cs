using UnityEngine;

public class Boy : Character
{
    [SerializeField]
    private Apple m_apple = null;
    public float m_delay = 3f;

    public override void InitCharacter()
    {
        HideApple();
    }

    public void HideApple()
    {
        m_apple.HideApple();
    }

    public void ShowApple()
    {
        m_apple.ShowApple();
    }

    public void AttachApple()
    {
        m_apple.AttachApple();
    }

    public void DetachApple()
    {
        m_apple.DetachApple();
    }
}
