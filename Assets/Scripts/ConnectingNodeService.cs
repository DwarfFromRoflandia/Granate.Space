using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ConnectingNodeService : MonoBehaviour
{
    [SerializeField] private Transform _contentTransform;

    public List<GameObject> PanelList = new List<GameObject>();

    public List<GameObject> UserList = new List<GameObject>();

    public void Initialize()
    {
        EventManager.AddPanelInListEvent.AddListener(AddPanel);
        EventManager.AddUserInListEvent.AddListener(AddUser);

        EventManager.RemovePanelInListEvent.AddListener(RemovePanel);
        EventManager.RemoveUserInListEvent.AddListener(RemoveUser);
    }

    public void AddUser(GameObject user)
    {
        UserList.Add(user);
    }

    public void AddPanel(GameObject informationalPanel)
    {
        PanelList.Add(informationalPanel);
        informationalPanel.transform.SetParent(_contentTransform, false);

        ConnectingNodeFromPanelToUser();
        ConnectingNodeFromUserToPanel();
    }

    public void RemoveUser(GameObject user)
    {
        UserList.Remove(user);
        ConnectingNodeFromUserToPanel();
    }

    public void RemovePanel(GameObject informationalPanel)
    {
        PanelList.Remove(informationalPanel);
    }

    public void ConnectingNodeFromPanelToUser()
    {
        for (int i = 0; i < PanelList.Count; i++)
        {
            PanelList[i].GetComponent<UserNicknameInInformationUserPanel>().SetUserNickname(UserList[i].GetComponent<User>().PhotonView.Owner.NickName);
            PanelList[i].GetComponent<SetID>().SetIDText(UserList[i].GetComponent<User>().PhotonView.Owner.ActorNumber.ToString());
        }
    }

    public void ConnectingNodeFromUserToPanel()
    {
        SetNumberButtons();
    }

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

                if (informationPanel.IsMine)
                {
                    moreActionPanel.Spawn(4);
                }
                else if (user.IsMine && user.Owner.NickName == PhotonNetwork.MasterClient.NickName)
                {
                    moreActionPanel.Spawn(6);
                }
                else if (user.IsMine && user.Owner.NickName != PhotonNetwork.MasterClient.NickName)
                {
                    moreActionPanel.Spawn(5);
                }
            }

        }

    }
}
