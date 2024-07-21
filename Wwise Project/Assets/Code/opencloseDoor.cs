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
        public Key requiredKey; // Verweis auf den benötigten Schlüssel

        void Start()
        {
            open = false;
        }

        void OnMouseOver()
        {
            if (Player)
            {
                float dist = Vector3.Distance(Player.position, transform.position);
                if (dist < 2.5f)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (open == false)
                        {
                            if (requiredKey == null || requiredKey.isCollected)
                            {
                                StartCoroutine(opening());
                            }
                            else
                            {
                                Debug.Log("Door is locked. Key required.");
                                AkSoundEngine.PostEvent(doorLockedEvent.Id, this.gameObject);
                            }
                        }
                        else
                        {
                            StartCoroutine(closing());
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
