using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour, IGreeting
{
    public void Greeting()
    {
        Debug.Log("� ����� � �� ��� ���������. ���-��� <3");
    }
}
