using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrot : MonoBehaviour, IGreeting
{
    public void Greeting()
    {
        Debug.Log("� ������� � �� ��� �� ���������. ���� ������� *������ ��������*");
    }
}
