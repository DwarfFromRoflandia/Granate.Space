using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager
{
    public static UnityEvent CameraShakeEvent = new UnityEvent();
    public static UnityEvent GlowEdgesScreenEvent = new UnityEvent();
    public static UnityEvent<User> WindowUsersEvent = new UnityEvent<User>();
    public static UnityEvent<User> RemoveUserFromWindowUsersEvent = new UnityEvent<User>();
    public static UnityEvent <Dictionary<int, User>, int> SetUserNicknameEvent = new UnityEvent<Dictionary<int, User>, int>();

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

    public static void OnRemoveUserFromWindowUsers(User user)
    {
        if (RemoveUserFromWindowUsersEvent != null) RemoveUserFromWindowUsersEvent.Invoke(user);
    }

    public static void OnSetUserNickname(Dictionary<int, User> dictionaryUsers, int key)
    {
        if (SetUserNicknameEvent != null) SetUserNicknameEvent.Invoke(dictionaryUsers, key);
    }
}
