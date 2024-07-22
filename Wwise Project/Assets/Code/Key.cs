using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	public Transform Player;
	public bool isCollected = false;

	[SerializeField]
	private AK.Wwise.Event keyPickupEvent;

	void OnMouseOver()
	{
		if (Player)
		{
			float dist = Vector3.Distance(Player.position, transform.position);
			if (dist < 2.5f)
			{
				if (Input.GetMouseButtonDown(0))
				{
					isCollected = true;
					AkSoundEngine.PostEvent(keyPickupEvent.Id, this.gameObject);
					gameObject.SetActive(false); // Deaktiviert den Schlüssel nach dem Einsammeln

				}
			}
		}
	}
}
