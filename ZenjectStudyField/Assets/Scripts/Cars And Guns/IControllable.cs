using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IControllable
{
    void Controller(float speed, float turningSpeed, Transform transform);
}
