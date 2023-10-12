using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrot : IGreeting
{
    public void Greeting()
    {
        Debug.Log("Я попугай и ты мне не нравишься. Хочу улететь *махает крыльями*");
    }
}
