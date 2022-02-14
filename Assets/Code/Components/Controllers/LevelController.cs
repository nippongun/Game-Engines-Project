using System.Collections;
using UnityEngine;

public class LevelController : Controller
{
    [SerializeField]
    private Boy m_boy = null;
    [SerializeField]
    private Girl m_girl = null;
    private float m_delay = 0.0f;
    [SerializeField]
    private ParticleSystem m_splashEffectPS = null;

    public override void Start()
    {
        base.Start();
    }

    public override void HideScene()
    {
        base.HideScene();
        m_boy.HideApple();
    }

    public override void StartScene()
    {
        m_boy.InitCharacter();
        m_girl.InitCharacter();

        Game.m_boy = m_boy;
        Game.m_girl = m_girl;

        Game.OnAppleMissed += Game_OnAppleMissed;

        StartCoroutine(ThrowApple());
    }

    private void Game_OnAppleMissed()
    {
        m_splashEffectPS.transform.position = Game.m_boy.m_apple.transform.position;
        m_splashEffectPS.Stop();
        m_splashEffectPS.Play();
    }

    public override void StopScene()
    {
        m_girl.ClearCharacter();
    }

    private IEnumerator ThrowApple()
    {
        m_delay = Random.Range(0f, 5f) + m_boy.m_delay;
        yield return new WaitForSeconds(m_delay);
        Game.m_boy.m_animator.SetTrigger("PickupApple");
        StartCoroutine(ThrowApple());
    }
}
