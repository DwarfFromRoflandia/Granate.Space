using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    public IGreeting _greeting;
    Player player = new Player();

    private void Start()
    {
        player.SwitchAnimal(_greeting);
        player.TakeAnimal();
    }
}
