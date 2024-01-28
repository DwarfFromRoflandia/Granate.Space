using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddedPanelToList : MonoBehaviour
{
    private void Start()
    {
        EventManager.OnAddPanelInList(gameObject);
    }

    private void OnDestroy()
    {
        EventManager.OnRemovePanelInList(gameObject);
    }
}
