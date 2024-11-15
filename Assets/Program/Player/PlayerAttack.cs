using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private bool direction;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shotPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Shot()
    {
        var Bullet = Instantiate(bullet, shotPos.position,Quaternion.identity,transform);
        Bullet.transform.parent = null;
        Bullet.GetComponent<Bullet>().Initialize(tag,direction,bulletSpeed);
    }
}
