using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour {

	// This script destroys the target shortly after it hits the ground
	
	// Update is called once per frame
	void Update () {

		if (gameObject.transform.position.y < 1)
		{
			Destroy(gameObject, 0.5f);
		}
	}
}
