using UnityEngine;

public class Girl : Character
{
    public override void InitCharacter()
    {
        Game.OnLeft += Game_OnLeft;
        Game.OnRight += Game_OnRight;
    }

    public void ClearCharacter()
    {
        Game.OnLeft -= Game_OnLeft;
        Game.OnRight -= Game_OnRight;
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
