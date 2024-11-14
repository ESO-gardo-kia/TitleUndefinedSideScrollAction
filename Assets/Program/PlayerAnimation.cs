using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void SetMoveAnime(int speed)
    {
        animator.SetInteger("speed", speed);
    }
    public void SetJumpAnime()
    {
        animator.SetTrigger("Jump");
    }
}
