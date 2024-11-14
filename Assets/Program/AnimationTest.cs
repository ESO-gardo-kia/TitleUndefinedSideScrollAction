using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationTest : MonoBehaviour
{
    [SerializeField] Animator anime;
    void Start()
    {
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.localEulerAngles = Vector3.up * 1;
            transform.position += Vector3.right * 0.1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localEulerAngles = Vector3.up * 181;
            transform.position += Vector3.left * 0.1f;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anime.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.E) && anime.GetInteger("AttackLevel") == 0)
        {
            anime.SetInteger("AttackLevel", 1);
        }
        else if (Input.GetKeyDown(KeyCode.E) && anime.GetInteger("AttackLevel") == 1)
        {
            anime.SetInteger("AttackLevel", 2);
        }
        else if (Input.GetKeyDown(KeyCode.E) && anime.GetInteger("AttackLevel") == 2)
        {
            anime.SetInteger("AttackLevel", 3);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            anime.SetTrigger("HardAttack");
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W))
        {
            anime.SetInteger("speed", 1);
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.W))
        {
            anime.SetInteger("speed", 0);
        }
    }
    public void WeakReset()
    {
        anime.SetInteger("AttackLevel", 0);
    }
}
