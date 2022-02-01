
using UnityEngine;

public class Character : MonoBehaviour
{
    [HideInInspector]
    public Animator animator = null;

    public virtual void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    public virtual void InitCharacter()
    {

    }
}
