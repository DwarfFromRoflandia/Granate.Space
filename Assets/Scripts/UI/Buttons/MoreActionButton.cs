using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoreActionButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _moreActionPanel;
    private bool isClick = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        isClick = !isClick;

        if (isClick) _moreActionPanel.SetActive(true);
        else _moreActionPanel.SetActive(false);
    }
}
