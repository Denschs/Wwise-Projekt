using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOnMusicResumeTrigger : MonoBehaviour
{
	public Transform Player;
	[SerializeField] GameObject triggerToAticate;
	void OnMouseOver()
	{
		if (Player)
		{
			float dist = Vector3.Distance(Player.position, transform.position);
			if (dist < 2.5f)
			{
				if (Input.GetMouseButtonDown(0))
				{
					triggerToAticate.SetActive(true);

				}
			}
		}
	}
}
