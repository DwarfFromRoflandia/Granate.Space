using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonServiceOnPanelMoreActions : MonoBehaviour
{
    public List<GameObject> ButtonsList = new List<GameObject>();
    private void Start()
    {
        EventManager.SpawnButtonsInActionsPanelEvent.AddListener(Spawn);
    }

    public void Spawn(int quantityButtons)
    {
        for (int i = 0; i < ButtonsList.Count; i++)
        {
            //if (quantityButtons == 6)
            //{
            //    ButtonsList[i].SetActive(true);
            //    Debug.Log("Six Buttons");
            //}
            //else if (quantityButtons == 5)
            //{
            //    ButtonsList[0].SetActive(true);
            //    ButtonsList[1].SetActive(false);
            //    Debug.Log("Five Buttons");
            //}
            //else
            //{
            //    ButtonsList[i].SetActive(false);
            //    Debug.Log("Four Buttons");
            //}

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
