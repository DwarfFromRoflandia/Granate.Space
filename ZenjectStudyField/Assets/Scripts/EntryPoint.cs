using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private GameObject _animal;
    Player player = new Player();

    

    private void Start()
    {
        if (_animal.TryGetComponent(out IGreeting greeting))
        {
            player.SwitchAnimal(greeting);
            player.TakeAnimal();
        }       
    }
}
