using UnityEngine;

public class Girl : Character
{
    private bool m_catchMode = false;
    public float m_catchRadius = 1f;

    public override void InitCharacter()
    {
        Game.OnLeft += Game_OnLeft;
        Game.OnRight += Game_OnRight;
        m_catchMode = true;
    }

    public void ClearCharacter()
    {
        Game.OnLeft -= Game_OnLeft;
        Game.OnRight -= Game_OnRight;
        m_catchMode = false;
    }

    public void SetCatchMode(bool value)
    {
        m_catchMode = value;
    }

    private void LateUpdate()
    {
        if (m_catchMode)
        {
            Vector3 p = Game.m_boy.m_apple.transform.position;
            float d = Vector3.Distance(
                this.transform.position,
                p);
            if (d < m_catchRadius)
            {
                Game.m_boy.HideApple();
                Debug.Log("GOT APPLE!");
            }
        }
    }

    private void Game_OnRight()
    {
        Vector3 p = this.transform.position;
        p.x -= 0.05f;
        this.transform.position = p;
    }

    private void Game_OnLeft()
    {
        Vector3 p = this.transform.position;
        p.x += 0.05f;
        this.transform.position = p;
    }
}
