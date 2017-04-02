using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RobotMovement : MonoBehaviour {

	Transform player;
	//PlayerHealth playerHealth;
	//RobotHealth robotHealth;
	NavMeshAgent nav;

	private void Awake() {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		nav = GetComponent<NavMeshAgent>();
	}


	// Update is called once per frame
	void Update () {
		nav.SetDestination(player.position);
	}
}
