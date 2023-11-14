using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _turningSpeed;
    private Rigidbody _rigidbody;

 
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void MoveUser(Vector3 moveDirection)
    {
        Vector3 offset = moveDirection * _speed * Time.deltaTime;

        _rigidbody.MovePosition(_rigidbody.position + offset);
    }

    public void RoatateUser(Vector3 moveDirection)
    {
        if (Vector3.Angle(transform.forward, moveDirection) > 0)
        {
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, moveDirection, _turningSpeed, 0);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
}
