using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Creating a single entry point in the program 
 * to manage the order of initialization method calls 
 * from classes in which they are implemented.
 */

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private PhotonManager _photonManager;
    private void Start()
    {
        _photonManager.Intialize(); //подключение к серверу, использу€ настройки файла
    }
}
