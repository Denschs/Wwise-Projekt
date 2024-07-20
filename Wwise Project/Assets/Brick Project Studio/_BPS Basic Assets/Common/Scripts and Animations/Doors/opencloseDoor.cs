using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;
		public GameObject flashBangDoor;
		[SerializeField]
		private AK.Wwise.Event doorOpenEvent;
		[SerializeField]
		private AK.Wwise.Event doorLockedEvent;

		void Start()
		{
			open = false;
		}

		void OnMouseOver()
		{
			{
				if (Player)
				{
					float dist = Vector3.Distance(Player.position, transform.position);
					if (dist < 2.5f)
					{
						if (open == false)
						{
							if (Input.GetMouseButtonDown(0))
							{
								StartCoroutine(opening());
							}
						}
						else
						{
							if (open == true)
							{
								if (Input.GetMouseButtonDown(0))
								{
									StartCoroutine(closing());
								}
							}

						}

					}
				}

			}

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			if (flashBangDoor)
			{
				FlashBang flashBang = flashBangDoor.GetComponent<FlashBang>();
				if (flashBang != null)
				{
					Debug.Log("WhiteImage eingeschaltet");
					StartCoroutine(flashBang.WhiteFade());
				}
				else
				{
					Debug.LogError("FlashBang component not found on the door GameObject.");
				}
			}
			AkSoundEngine.PostEvent(doorOpenEvent.Id, this.gameObject);
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}