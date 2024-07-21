using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	public Transform Player;
	public bool isCollected = false;

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
					gameObject.SetActive(false); // Deaktiviert den Schlüssel nach dem Einsammeln
					
				}
			}
		}
	}
}
