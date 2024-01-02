using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetID : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public void SetIDText(string id)
    {
        text.text = id;
    }
}
