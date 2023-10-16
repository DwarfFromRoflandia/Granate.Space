using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour, IGreeting
{
    public void Greeting()
    {
        Debug.Log("Я кошка и ты мне нравишься. Мур-мур <3");
    }
}
