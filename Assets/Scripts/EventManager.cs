using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class EventManager
{
    public static UnityEvent CameraShakeEvent = new UnityEvent();
    public static UnityEvent GlowEdgesScreenEvent = new UnityEvent();
    public static UnityEvent<User> AddUsersInListEvent = new UnityEvent<User>();
    public static UnityEvent<User> RemoveUsersInListEvent = new UnityEvent<User>();
    public static UnityEvent<User> SpawnInformationUserPanelEvent = new UnityEvent<User>();

    public static void OnCameraShake()
    {
        if (CameraShakeEvent != null) CameraShakeEvent.Invoke();
    }

    public static void OnGlowEdgesScreen()
    {
        if (GlowEdgesScreenEvent != null) GlowEdgesScreenEvent.Invoke();
    }

    public static void OnAddUsersInList(User user)
    { 
        if (AddUsersInListEvent != null) AddUsersInListEvent.Invoke(user);
    }

    public static void OnRemoveUsersInList(User user)
    {
        if (RemoveUsersInListEvent != null) RemoveUsersInListEvent.Invoke(user);
    }

    public static void OnSpawnInformationUserPanel(User user)
    {
        if (SpawnInformationUserPanelEvent != null) SpawnInformationUserPanelEvent.Invoke(user);
    }
}
