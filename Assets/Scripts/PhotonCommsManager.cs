using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon;

public class PhotonCommsManager : Photon.PunBehaviour {

	private GameObject currentPlayer;

	void Start () {
		PhotonNetwork.logLevel = PhotonLogLevel.Full;
		PhotonNetwork.ConnectUsingSettings ("0.1");
	}

	/////////////////////// Photon Methods  ///////////////////////

	public override void OnJoinedLobby () {
		PhotonNetwork.JoinRandomRoom ();
	}

	public override void OnJoinedRoom () {
		// instantiate user avatar locally and spawns in remote instances
		currentPlayer = PhotonNetwork.Instantiate("MyPlayer", new Vector3(Random.Range(-3, 3), 1.6f, Random.Range(-3, 3)), Quaternion.identity, 0); 
		currentPlayer.GetComponent<PlayerController>().isControllable = true;
	}

	// This is called if there is no one playing or if all rooms are full, so create a new room
	void OnPhotonRandomJoinFailed()
	{
		Debug.Log("Can't join random room!");
		PhotonNetwork.CreateRoom(null);
	}

	void OnGUI()
	{
		GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
	}
}
