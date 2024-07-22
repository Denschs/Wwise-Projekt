using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public GameObject triggerObject; // Das GameObject, dessen Aktivierung den Timer startet
    public int delay;

    private bool timerStarted = false;

    void Update()
    {
        // Überprüfe, ob das Trigger-Objekt aktiviert wurde und der Timer noch nicht gestartet ist
        if (triggerObject.activeInHierarchy && !timerStarted)
        {
            timerStarted = true;
            StartCoroutine(ReturnToMenuAfterDelay());
        }
    }

    IEnumerator ReturnToMenuAfterDelay()
    {
        
        yield return new WaitForSeconds(delay);

        
        loadMenu();
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
