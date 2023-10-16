using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public IMoveble SpaceShip { get; set; }
    public IControlable Controller { get; set; }

    //public void Initialize()
    //{
    //    _spaceShip = new SpaceShip();
    //    _controller = new KeyboardController();
    //}

    private void Update()
    {
        if (Controller.LeftCmdReceived()) SpaceShip.MoveLeft();
        else if(Controller.RightCmdReceived()) SpaceShip.MoveRight();
    }
}
