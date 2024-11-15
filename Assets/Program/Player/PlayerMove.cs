using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform leftBottomPos;
    [SerializeField] private Transform rightBottomPos;
    [SerializeField] private bool isGround;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float accelation;
    [SerializeField] private float jumpForce;
        [SerializeField] private float changeDirectionToleranceLevel = 0.1f;
    void Start()
    {
        
    }

    void Update()
    {

    }
    public bool Move()
    {
        if (maxSpeed >= rb.velocity.x)
        {
            rb.velocity += Vector3.right * (accelation * Time.deltaTime);
        }
        else
        {
            rb.velocity = new Vector3(maxSpeed, rb.velocity.y, rb.velocity.z);
        }
        if (rb.velocity.x > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool Jump()
    {
        IsJump();
        if (isGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            return true;
        }
        return false;
    }
    private void IsJump()
    {
        Ray ray = new Ray(transform.localPosition + leftBottomPos.transform.localPosition.x * Vector3.right, Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 10.0f))
        {
            float y = hit.point.y - leftBottomPos.position.y;
            if (-changeDirectionToleranceLevel < y && y < changeDirectionToleranceLevel) isGround = true;
            else isGround = false;
        }
        if (!isGround)
        {
            ray = new Ray(transform.localPosition + rightBottomPos.transform.localPosition.x * Vector3.right, Vector3.down);
            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                float y = hit.point.y - rightBottomPos.position.y;
                if (-changeDirectionToleranceLevel < y && y < changeDirectionToleranceLevel) isGround = true;
                else isGround = false;
            }
        }
    }
}
