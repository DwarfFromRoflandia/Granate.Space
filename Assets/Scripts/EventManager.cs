using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class EventManager
{
    public static UnityEvent CameraShakeEvent = new UnityEvent();
    public static UnityEvent GlowEdgesScreenEvent = new UnityEvent();
    public static UnityEvent<User> AddUsersInDictionaryEvent = new UnityEvent<User>();
    public static UnityEvent<int> RemoveUsersInDictionaryEvent = new UnityEvent<int>();


    public static void OnCameraShake()
    {
        if (CameraShakeEvent != null) CameraShakeEvent.Invoke();
    }

    public static void OnGlowEdgesScreen()
    {
        if (GlowEdgesScreenEvent != null) GlowEdgesScreenEvent.Invoke();
    }

    public static void OnAddUsersInDictionary(User user)
    { 
        if (AddUsersInDictionaryEvent != null) AddUsersInDictionaryEvent.Invoke(user);
    }

    public static void OnRemoveUsersInDictionary(int key)
    {
        if (RemoveUsersInDictionaryEvent != null) RemoveUsersInDictionaryEvent.Invoke(key);
    }
}
