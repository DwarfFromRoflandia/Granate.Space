using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class EventManager
{
    public static UnityEvent CameraShakeEvent = new UnityEvent();
    public static UnityEvent GlowEdgesScreenEvent = new UnityEvent();

    public static UnityEvent<User, GameObject> SetIDInDictionaryEvent = new UnityEvent<User, GameObject>();
    public static UnityEvent<User> DisableIDInDictionaryEvent = new UnityEvent<User>();

    public static UnityEvent<User> SpawnInformationUserPanelEvent = new UnityEvent<User>();

    public static void OnCameraShake()
    {
        if (CameraShakeEvent != null) CameraShakeEvent.Invoke();
    }

    public static void OnGlowEdgesScreen()
    {
        if (GlowEdgesScreenEvent != null) GlowEdgesScreenEvent.Invoke();
    }

    public static void OnSetIDInDictionary(User user, GameObject InformationalPanel)
    { 
        if (SetIDInDictionaryEvent != null) SetIDInDictionaryEvent.Invoke(user, InformationalPanel);
    }

    public static void OnDisableInDictionary(User user)
    {
        if (DisableIDInDictionaryEvent != null) DisableIDInDictionaryEvent.Invoke(user);
    }

    public static void OnSpawnInformationUserPanel(User user)
    {
        if (SpawnInformationUserPanelEvent != null) SpawnInformationUserPanelEvent.Invoke(user);
    }
}
