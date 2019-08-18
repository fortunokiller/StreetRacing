using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsCanvases : MonoBehaviour
{
    [SerializeField]
    private CreateOrJoinRoomCanvas _createOrJoinRoomCanvas;
    public CreateOrJoinRoomCanvas GetCreateOrJoinRoomCanvas { get { return _createOrJoinRoomCanvas; } }

    [SerializeField]
    private CurrentRoomCanvas _currentRoomCanvas;
    public CurrentRoomCanvas CurrentRoomCanvas { get { return _currentRoomCanvas; } }


    private void Awake()
    {
        FirstInitialize();
    }

    private void FirstInitialize()
    {
        GetCreateOrJoinRoomCanvas.FirstInitialize(this);
        CurrentRoomCanvas.FirstInitialize(this);
    }
}
