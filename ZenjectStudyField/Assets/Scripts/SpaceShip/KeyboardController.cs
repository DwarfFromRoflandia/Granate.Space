using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : IControlable
{

    public bool LeftCmdReceived() => Input.GetKeyDown(KeyCode.A);


    public bool RightCmdReceived() => Input.GetKeyDown(KeyCode.D);

}
