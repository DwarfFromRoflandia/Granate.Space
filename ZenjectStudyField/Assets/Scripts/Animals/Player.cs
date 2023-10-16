using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private IGreeting _greeting;

    public void SwitchAnimal(IGreeting greeting)
    {
        _greeting = greeting;
    }

    public void TakeAnimal()
    {
        _greeting.Greeting();
    }
}
