using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAssault : Enemy
{
    [SerializeField] private List<Transform> wheel;
    [SerializeField] private int wheelSpeed;
    private void Start()
    {
        Initialize();
    }
    private void Update()
    {
        Move();
        WheelRotate();
    }
    private void Initialize()
    {
        currentHp = hp;
    }
    private void Move()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
    private void Death()
    {
        Destroy(gameObject);
    }
    private void WheelRotate()
    {
        wheel[0].Rotate(Vector3.up * wheelSpeed);
        wheel[1].Rotate(Vector3.up * wheelSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerAttack"))
        {
            Death();
        }
    }
}
