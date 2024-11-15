using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private bool direction = true;
    [SerializeField] private float speed = 8;
    [SerializeField] private float lifeTime = 3;
    [SerializeField] private float currentLifeTime;
    void Start()
    {
        
    }
    void Update()
    {
        LifeTimer();
        Move();
    }
    private void LifeTimer()
    {
        if(currentLifeTime < lifeTime)
        {
            currentLifeTime += Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Move()
    {
        if (direction)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
    public void Initialize(string thisTag, bool Direction, float Speed)
    {
        direction = Direction;
        speed = Speed;
        if(thisTag == "Player")
        {
            tag = "PlayerAttack";
        }
        if (thisTag == "Enemy")
        {
            tag = "EnemyAttack";
        }
        if (direction)
        {
            transform.localEulerAngles = Vector3.up * 90;
        }
        else
        {
            transform.localEulerAngles = Vector3.down * -90;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
