using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour, IGreeting
{
    public void Greeting()
    {
        Debug.Log("Я собака и ты для меня нейтрален. Надеюсь, что подружимся, Гав-Гав");
    }
}
