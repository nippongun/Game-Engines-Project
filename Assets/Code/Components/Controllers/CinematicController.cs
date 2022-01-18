public class CinematicController : Controller
{
    public override void Start()
    {
        base.Start();
    }

    public override void StartScene()
    {
        Game.m_gameStateMachine.SetTrigger("Menu");
    }
}
