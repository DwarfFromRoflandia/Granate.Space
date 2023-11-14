using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : IControlable
{
    private UserMovement _userMovement;

    public KeyboardController(UserMovement userMovement)
    {
        _userMovement = userMovement;
    }
    public void Controller()
    {
        _userMovement.MoveUser(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        _userMovement.RoatateUser(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
    }
}
