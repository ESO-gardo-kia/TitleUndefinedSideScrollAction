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
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && animator.GetInteger("AttackLevel") == 0)
        {
            animator.SetInteger("AttackLevel", 1);
        }
        else if (Input.GetKeyDown(KeyCode.E) && animator.GetInteger("AttackLevel") == 1)
        {
            animator.SetInteger("AttackLevel", 2);
        }
        else if (Input.GetKeyDown(KeyCode.E) && animator.GetInteger("AttackLevel") == 2)
        {
            animator.SetInteger("AttackLevel", 3);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("HardAttack");
        }
    }
    public void WeakReset()
    {
        animator.SetInteger("AttackLevel", 0);
    }
}
