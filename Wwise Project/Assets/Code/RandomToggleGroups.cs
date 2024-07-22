using UnityEngine;
using System.Collections;

public class RandomToggleGroups : MonoBehaviour
{
    // Referenzen zu den GameObject-Gruppen
    public GameObject[] group1;
    public GameObject[] group2;

    void Start()
    {
        // Starte die Koroutinen für beide Gruppen
        StartCoroutine(ToggleGroup(group1));
        StartCoroutine(ToggleGroup(group2));
    }

    IEnumerator ToggleGroup(GameObject[] group)
    {
        while (true)
        {
            // Warte zufällig zwischen 1 und 3 Sekunden
            yield return new WaitForSeconds(Random.Range(1f, 3f));

            // Deaktiviere die Gruppe
            SetGroupActive(group, false);

            // Warte zufällig zwischen 1 und 2 Sekunden
            yield return new WaitForSeconds(Random.Range(0.2f, 1f));

            // Aktiviere die Gruppe
            SetGroupActive(group, true);
        }
    }

    void SetGroupActive(GameObject[] group, bool isActive)
    {
        foreach (GameObject obj in group)
        {
            obj.SetActive(isActive);
        }
    }
}
