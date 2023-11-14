using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    public IControllable Controllable { get; private set; }

    [Inject]
    public void Construct(IControllable controllable)
    {
        Controllable = controllable;
        
        Debug.Log(Controllable.GetType());
    }
}
