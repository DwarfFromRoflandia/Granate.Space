using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : IControlable
{
    public void Controller(float speed, float turningSpeed)
    {
        MonoBehaviour monoBehaviour = new MonoBehaviour();
        monoBehaviour.transform.Rotate(0, Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime, 0);
        monoBehaviour.transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }
}
