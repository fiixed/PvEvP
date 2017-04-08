using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class TeleportEvent : UnityEvent<Vector3>
{
}

public class TeleportController : MonoBehaviour {

	public TeleportEvent teleportEvent;

	void Start()
	{
		if (teleportEvent == null) {
			teleportEvent = new TeleportEvent ();
		}
	}

	public void TeleportTo(BaseEventData data ) {
		PointerEventData pointerData = data as PointerEventData;
		Vector3 worldPos = pointerData.pointerCurrentRaycast.worldPosition;
		teleportEvent.Invoke(worldPos);
	}
}
