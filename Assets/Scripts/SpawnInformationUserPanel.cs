using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnInformationUserPanel : MonoBehaviour
{
    [SerializeField] private GameObject _informationPanelPrefab;
    [SerializeField] private GameObject _contentScrollView;

    public void Initialize()
    {
        EventManager.SpawnInformationUserPanelEvent.AddListener(SpawnPanel);
    }

    private void SpawnPanel(User user) => user.InformationUserPanel = Instantiate(_informationPanelPrefab, _contentScrollView.transform);
}
