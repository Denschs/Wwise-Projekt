using UnityEngine;

public class DisableBoxColliderOnExit : MonoBehaviour
{
    private BoxCollider boxCollider;

    void Start()
    {
        // Hole den BoxCollider-Komponente beim Start des Spiels
        boxCollider = GetComponent<BoxCollider>();

        // Überprüfe, ob der BoxCollider gefunden wurde
        if (boxCollider == null)
        {
            Debug.LogError("Kein BoxCollider an diesem GameObject gefunden!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Überprüfe, ob der BoxCollider existiert, bevor du ihn deaktivierst
        if (boxCollider != null)
        {
            boxCollider.enabled = false;
            Debug.Log("BoxCollider wurde deaktiviert.");
        }
    }
}
