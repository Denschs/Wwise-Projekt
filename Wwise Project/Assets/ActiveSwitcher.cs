using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject switcherBuddy;
    
    private void OnTriggerEnter(Collider other)
    {
        switcherBuddy.SetActive(true);
        gameObject.SetActive(false);
    }
}
