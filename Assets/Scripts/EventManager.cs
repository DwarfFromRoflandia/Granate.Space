using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class EventManager
{
    public static UnityEvent CameraShakeEvent = new UnityEvent();
    public static UnityEvent GlowEdgesScreenEvent = new UnityEvent();
    public static UnityEvent<User> WindowUsersEvent = new UnityEvent<User>();


    public static void OnCameraShake()
    {
        if (CameraShakeEvent != null) CameraShakeEvent.Invoke();
    }

    public static void OnGlowEdgesScreen()
    {
        if (GlowEdgesScreenEvent != null) GlowEdgesScreenEvent.Invoke();
    }

    public static void OnWindowUsersEvent(User user)
    { 
        if (WindowUsersEvent != null) WindowUsersEvent.Invoke(user);
    }
}
