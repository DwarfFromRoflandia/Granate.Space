using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private IMoveble _character;
    public IControlable _controller;

    //public void Inject(IMoveble character, IControlable controller)
    //{
    //    _character = character;
    //    _controller = controller;
    //}

    public void Initialize()
    {
        _character = new SpaceShip();
        _controller = new KeyboardController();
    }

    private void Update()
    {
        if (_controller.LeftCmdReceived()) _character.MoveLeft();
        else if(_controller.RightCmdReceived()) _character.MoveRight();
    }
}
