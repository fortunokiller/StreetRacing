using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPropertyGenerator : MonoBehaviour
{
    [SerializeField]
    private Text _text;
    private ExitGames.Client.Photon.Hashtable _myCustomProperties = new ExitGames.Client.Photon.Hashtable();

    public void SetCustomNumber()
    {
        System.Random rnd = new System.Random();
        int result = rnd.Next(0, 99);

        _text.text = result.ToString();

        _myCustomProperties["RandomNumber"] = result;
        //_myCustomProperties.Remove("RandomNumber");
        PhotonNetwork.LocalPlayer.CustomProperties = _myCustomProperties;
    }

    public void Onclick_Button()
    {
        SetCustomNumber();
    }
}
