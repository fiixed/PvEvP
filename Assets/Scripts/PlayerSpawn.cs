using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour {

	public GameObject playerPrefab;

	// Use this for initialization
	void Start () {
		Instantiate(playerPrefab, new Vector3(Random.Range(-3, 3), 1.6f, Random.Range(-3, 3)), Quaternion.identity);
	}
	
	
}
