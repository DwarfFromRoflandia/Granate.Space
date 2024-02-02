using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonServiceOnPanelMoreActions : MonoBehaviour
{
    [SerializeField] private List<GameObject> ButtonsList = new List<GameObject>();

    public void Spawn(int quantityButtons)
    {
        for (int i = 0; i < ButtonsList.Count; i++)
        {
            switch (quantityButtons)
            {
                case 4:
                    ButtonsList[i].SetActive(false);
                    break;
                case 5:
                    ButtonsList[0].SetActive(true);
                    ButtonsList[1].SetActive(false);
                    break;
                case 6:
                    ButtonsList[i].SetActive(true);
                    break;
                default:
                    break;
            }
        }
    }
}
