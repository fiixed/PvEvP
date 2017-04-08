using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTarget : MonoBehaviour {

	// This script fires target prefabs from an array of spawn points at a specified force

	public Rigidbody targetPrefab;

	public Transform[] targetSpawnPoints;

	public float force;

	private bool fireTarget = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (fireTarget == true)
		{
			fireTarget = false;
			// Instantiate the target prefab for each spawn point added to the script
			foreach (Transform spawnPoint in targetSpawnPoints)
			{
				Rigidbody targetInstance;
				targetInstance = Instantiate(targetPrefab, spawnPoint.position, spawnPoint.rotation) as Rigidbody;
				// Add force to shoot the targets out of the top end of the spawn points (which are cylinders for easy adjustment & can be made invisible to the camera later)
				targetInstance.AddForce(spawnPoint.up * force);
			}
		}

		if (Input.GetKeyDown("space")) // Used only for testing without Daydream - will be deleted
		{
			fireTargetNow();
		}
	
	}

	public void fireTargetNow()
	{
		fireTarget = true;
	}
}
