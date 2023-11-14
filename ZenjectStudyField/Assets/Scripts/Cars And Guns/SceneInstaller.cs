using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IControllable>().To<KeyboardController>().AsSingle();
        Container.Bind<Player>().AsSingle();
        Container.Bind<Transport>().AsSingle();
    }
}
