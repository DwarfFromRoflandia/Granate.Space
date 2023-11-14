using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamalyCar : Transport, IMoveble
{
    private void Update()
    {
        Move();
    }

    public void Move()
    {
        _player.Controllable.Controller(_speed, _turningSpeed, gameObject.transform);
    }
}
