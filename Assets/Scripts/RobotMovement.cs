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
		nav = GetComponent<NavMeshAgent>();
	}

	private void Start() {
		InvokeRepeating("FindPlayer", 5.0f, 10.0f);
	}


	// Update is called once per frame
	void Update () {
		if (player) {
			nav.SetDestination(player.position);
		}
	}

	void FindPlayer() {
		if (player == null) {
			player = GameObject.FindGameObjectWithTag("Player").transform;
		}
		
	}
}
