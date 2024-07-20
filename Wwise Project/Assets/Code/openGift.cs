using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openGift : MonoBehaviour
{
	public Transform Player;
	public GameObject endPanel;
	void OnMouseOver()
	{
		if (Player)
		{
			float dist = Vector3.Distance(Player.position, transform.position);
			if (dist < 2.5f)
			{
				if (Input.GetMouseButtonDown(0))
				{
					endPanel.SetActive(true);
				}
			}
		}
	}
}
