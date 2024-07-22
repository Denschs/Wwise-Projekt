using UnityEngine;

public class DisableBoxColliderOnExit : MonoBehaviour
{
    private BoxCollider boxCollider;

    void Start()
    {
        // Hole den BoxCollider-Komponente beim Start des Spiels
        boxCollider = GetComponent<BoxCollider>();

        // �berpr�fe, ob der BoxCollider gefunden wurde
        if (boxCollider == null)
        {
            Debug.LogError("Kein BoxCollider an diesem GameObject gefunden!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        // �berpr�fe, ob der BoxCollider existiert, bevor du ihn deaktivierst
        if (boxCollider != null)
        {
            boxCollider.enabled = false;
            Debug.Log("BoxCollider wurde deaktiviert.");
        }
    }
}
