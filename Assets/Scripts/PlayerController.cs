using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject gvrControllerPointer;
	public GameObject head;
	public GameObject otherPlayersController;
	public GameObject playerCamera;

	// Used to check if is this user's player or an external player
	public bool isControllable;

	// Use this for initialization
	void Start () {
		if (isControllable) {
			TeleportEvent teleportEvent = GameObject.Find("TeleportController").GetComponent<TeleportController>().teleportEvent;
			teleportEvent.AddListener (HandleTeleportEvent);
			playerCamera.SetActive (true);
			gvrControllerPointer.SetActive (true);
			head.SetActive (false);
			otherPlayersController.SetActive (false);
			GetComponent<PhotonVoiceRecorder>().enabled = true;
		} else {
			playerCamera.SetActive (false);
			gvrControllerPointer.SetActive (false);
		}
	}

	// Handle Telelport UnityEvent
	private void HandleTeleportEvent (Vector3 worldPos){
		gameObject.transform.position = new Vector3(worldPos.x, gameObject.transform.position.y, worldPos.z);
	}
}
