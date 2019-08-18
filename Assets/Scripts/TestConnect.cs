using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConnect : MonoBehaviourPunCallbacks
{
    
    void Start()
    {
        print("conectando ao servidor...");
        AuthenticationValues authValues = new AuthenticationValues("0");
        PhotonNetwork.AuthValues = authValues;
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        
        Debug.Log("Connected to Photon.", this);

        /*Debug.Log("My name is " + PhotonNetwork.LocalPlayer.NickName, this);
        if (!PhotonNetwork.InLobby)
            PhotonNetwork.JoinLobby();*/
        if (!PhotonNetwork.InLobby)
        {
            PhotonNetwork.JoinLobby();
        }       
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("failed  to connect to Photon: "+ cause.ToString(),this);
    }

    public override void OnJoinedLobby()
    {
        print("Joined lobby");
        PhotonNetwork.FindFriends(new string[]{"1"});
    }

    public override void OnFriendListUpdate(List<FriendInfo> friendList)
    {
        base.OnFriendListUpdate(friendList);
        foreach (FriendInfo info in friendList)
        {
            Debug.Log("Friends info recieved " + info.UserId + " is mine? " + info.IsOnline);
        }
    }
}