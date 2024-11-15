using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationTest : MonoBehaviour
{
    [SerializeField] Animator anime;
    public void WeakReset()
    {
        anime.SetInteger("AttackLevel", 0);
    }
}
