using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShowUsersButton : MonoBehaviour
{
    [SerializeField] private Color _pressedButtonColor;
    [SerializeField] private GameObject _panelUsers;
    [SerializeField] private Image _image;
    [SerializeField] private RectTransform _blackPanel;
    public bool click = false;

    public void Click()
    {
        click = !click;

        if (click)
        {
            ChangeColor(_pressedButtonColor);
            _panelUsers.SetActive(true);
            _blackPanel.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 449); 
        }
        else
        {
            ChangeColor(Color.white);
            _panelUsers.SetActive(false);
            _blackPanel.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 120);
        }
    }

    private void ChangeColor(Color color) => _image.color = color;
}
