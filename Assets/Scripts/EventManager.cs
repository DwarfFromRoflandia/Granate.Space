using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class EventManager
{
    public static UnityEvent SpawnUserSphereEvent = new UnityEvent();

    public static UnityEvent CameraShakeEvent = new UnityEvent();
    public static UnityEvent GlowEdgesScreenEvent = new UnityEvent();

    public static UnityEvent<GameObject> AddPanelInListEvent = new UnityEvent<GameObject>();
    public static UnityEvent<GameObject> AddUserInListEvent = new UnityEvent<GameObject>();
    public static UnityEvent<GameObject> RemovePanelInListEvent = new UnityEvent<GameObject>();
    public static UnityEvent<GameObject> RemoveUserInListEvent = new UnityEvent<GameObject>();

    public static UnityEvent<int> SpawnButtonsInActionsPanelEvent = new UnityEvent<int>();

    public static void OnSpawnUserSphere()
    {
        if (SpawnUserSphereEvent != null) SpawnUserSphereEvent.Invoke();
    }

    public static void OnCameraShake()
    {
        if (CameraShakeEvent != null) CameraShakeEvent.Invoke();
    }

    public static void OnGlowEdgesScreen()
    {
        if (GlowEdgesScreenEvent != null) GlowEdgesScreenEvent.Invoke();
    }

    public static void OnAddPanelInList(GameObject InformationalPanel)
    {
        if (AddPanelInListEvent != null)
        {
            AddPanelInListEvent.Invoke(InformationalPanel);
        }
    }

    public static void OnAddUserInList(GameObject user)
    {
        if (AddUserInListEvent != null)
        {
            AddUserInListEvent.Invoke(user);
        }
    }

    public static void OnRemovePanelInList(GameObject InformationalPanel)
    {
        if (RemovePanelInListEvent != null)
        {
            RemovePanelInListEvent.Invoke(InformationalPanel);
        }
    }

    public static void OnRemoveUserInList(GameObject user)
    {
        if (RemoveUserInListEvent != null)
        {
            RemoveUserInListEvent.Invoke(user);
        }
    }

    public static void OnSpawnButtonsInActionsPanel(int quantityButtons)
    {
        if (SpawnButtonsInActionsPanelEvent != null)
        {
            SpawnButtonsInActionsPanelEvent.Invoke(quantityButtons);
        }
    }
}
