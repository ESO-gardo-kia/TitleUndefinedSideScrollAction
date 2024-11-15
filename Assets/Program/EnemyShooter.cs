using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : Enemy
{
    [SerializeField] private List<Transform> wheel;
    [SerializeField] private int wheelSpeed;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shotPos;
    [SerializeField] private bool direction;
    [SerializeField] private float bulletSpeed;
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
    private void Shot()
    {
        var Bullet = Instantiate(bullet, shotPos.position, Quaternion.identity, transform);
        Bullet.transform.parent = null;
        Bullet.GetComponent<Bullet>().Initialize(tag, direction, bulletSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerAttack"))
        {
            Death();
        }
    }
}
