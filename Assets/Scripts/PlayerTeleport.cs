using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour {

	void Update() {
		if (GvrController.ClickButtonUp) {
			GvrLaserPointerImpl laserPointerImpl = (GvrLaserPointerImpl)GvrPointerManager.Pointer;
			if (laserPointerImpl.IsPointerIntersecting) {
				float y = 0;
				y = laserPointerImpl.PointerIntersection.y + transform.position.y;
				transform.position = new Vector3(laserPointerImpl.PointerIntersection.x, y, laserPointerImpl.PointerIntersection.z);
			}
		}
	}
}
