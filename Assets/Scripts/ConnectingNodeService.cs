using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ConnectingNodeService : MonoBehaviour
{
    [SerializeField] private Transform _contentTransform;

    [SerializeField] private List<GameObject> PanelList = new List<GameObject>();

    [SerializeField] private List<GameObject> UserList = new List<GameObject>();

    public void Initialize()
    {
        EventManager.AddPanelInListEvent.AddListener(AddPanel);
        EventManager.AddUserInListEvent.AddListener(AddUser);

        EventManager.RemovePanelInListEvent.AddListener(RemovePanel);
        EventManager.RemoveUserInListEvent.AddListener(RemoveUser);
    }

    private void AddUser(GameObject user) => UserList.Add(user);

    private void AddPanel(GameObject informationalPanel)
    {
        PanelList.Add(informationalPanel);
        informationalPanel.transform.SetParent(_contentTransform, false);

        ConnectingNodeFromPanelToUser();
        ConnectingNodeFromUserToPanel();
    }

    private void RemoveUser(GameObject user)
    {
        UserList.Remove(user);
        ConnectingNodeFromUserToPanel();
    }

    private void RemovePanel(GameObject informationalPanel) => PanelList.Remove(informationalPanel);

    private void ConnectingNodeFromPanelToUser()
    {
        for (int i = 0; i < PanelList.Count; i++)
        {
            PanelList[i].GetComponent<UserNicknameInInformationUserPanel>().SetUserNickname(UserList[i].GetComponent<User>().PhotonView.Owner.NickName);
        }
    }

    private void ConnectingNodeFromUserToPanel() => SetNumberButtons();

    private void SetNumberButtons()
    {
        PhotonView user;
        PhotonView informationPanel;
        ButtonServiceOnPanelMoreActions moreActionPanel;

        for (int i = 0; i < UserList.Count; i++)
        {
            for (int j = 0; j < PanelList.Count; j++)
            {
                user = UserList[i].GetComponent<PhotonView>();
                informationPanel = PanelList[j].GetComponent<PhotonView>();
                moreActionPanel = PanelList[j].GetComponent<ButtonServiceOnPanelMoreActions>();

                if (informationPanel.IsMine) moreActionPanel.Spawn(4);
                else if (user.IsMine && user.Owner.NickName == PhotonNetwork.MasterClient.NickName) moreActionPanel.Spawn(6);
                else if (user.IsMine && user.Owner.NickName != PhotonNetwork.MasterClient.NickName) moreActionPanel.Spawn(5);
            }

        }
    }
}
