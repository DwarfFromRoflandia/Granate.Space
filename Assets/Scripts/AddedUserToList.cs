using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddedUserToList : MonoBehaviour
{
    private void Start()
    {
        EventManager.OnAddUserInList(gameObject);
    }

    private void OnDestroy()
    {
        EventManager.OnRemoveUserInList(gameObject);
    }
}
