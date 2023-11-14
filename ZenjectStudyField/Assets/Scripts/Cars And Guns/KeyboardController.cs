using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour, IControllable
{
    public void Controller(float speed, float turningSpeed, Transform transform)
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }
}
