using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : IMoveble
{
    public void MoveLeft() => Debug.Log("SpaceShip Moving Left");

    public void MoveRight() => Debug.Log("SpaceShip Moving Right");
}
