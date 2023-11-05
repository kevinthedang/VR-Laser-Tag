using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{

    private GameObject _spawnedPlayerPrefab;
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        _spawnedPlayerPrefab = PhotonNetwork.Instantiate("Player Rig", transform.position, transform.rotation);
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(_spawnedPlayerPrefab);
    }
}
