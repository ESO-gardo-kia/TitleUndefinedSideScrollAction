using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMainSystem : MonoBehaviour
{
    [SerializeField] Action GameOver;
    [SerializeField] PlayerAnimation anime;
    [SerializeField] PlayerMove move;
    [SerializeField] private int hp = 3;
    [SerializeField] private int currentHp;
    [SerializeField] private Text hpText;
    void Start()
    {
        currentHp = hp;
        hpText.text = "HP:" + currentHp.ToString() + "/" + hp;
    }
    void Update()
    {
        if (GameManager.isGame)
        {
            Debug.Log("");
            if (Input.GetKeyDown(KeyCode.Space) && move.Jump())
            {
                anime.SetJumpAnime();
            }
            if (move.Move())
            {
                anime.SetMoveAnime(1);
            }
            else
            {
                anime.SetMoveAnime(0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy") || other.CompareTag("EnemyAttack"))
        {
            if (currentHp > 0)
            {
                currentHp--;
                hpText.text = "HP:" + currentHp.ToString() + "/" + hp;
            }
            if (currentHp == 0)
            {
                GameOver();
            }
        }
    }
}
