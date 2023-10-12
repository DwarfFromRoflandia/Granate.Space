using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _turningSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * _turningSpeed * Time.deltaTime, 0);
        transform.Translate(0,0, Input.GetAxis("Vertical") * _speed * Time.deltaTime);
    }
}
