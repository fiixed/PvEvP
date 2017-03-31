using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour {

	void Update() {
		if (GvrController.AppButtonUp) {
			GvrLaserPointerImpl laserPointerImpl = (GvrLaserPointerImpl)GvrPointerManager.Pointer;
			if (laserPointerImpl.IsPointerIntersecting) {
			
				transform.position = new Vector3(laserPointerImpl.PointerIntersection.x, transform.position.y, laserPointerImpl.PointerIntersection.z);
			}
		}
	}
}
