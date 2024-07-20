using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditsConvas;
    public GameObject tutorialConvas;

    [SerializeField]
    private AK.Wwise.Event buttonSFX;
    [SerializeField]
    private AK.Wwise.Event startGame;



    public void playGame()
    {
        StartCoroutine(_PlayGame());

        //introCanvas.SetActive(true);
        //SceneManager.LoadScene("Main");
    }
    private IEnumerator _PlayGame()
    {
        AkSoundEngine.PostEvent(startGame.Id, this.gameObject);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Blockout");
        //mainMenu.SetActive(false);
    }
    public void playGameReverseScene()
    {
        StartCoroutine(_playGameReverseScene());

        //introCanvas.SetActive(true);
        //SceneManager.LoadScene("Main");
    }
    private IEnumerator _playGameReverseScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Main_ReverseTarget");
        //mainMenu.SetActive(false);
    }

    public void showCredits()
    {
        AkSoundEngine.PostEvent(buttonSFX.Id, this.gameObject);
        mainMenu.SetActive(false);
        creditsConvas.SetActive(true);
    }

    public void hideCredits()
    {
        AkSoundEngine.PostEvent(buttonSFX.Id, this.gameObject);
        mainMenu.SetActive(true);
        creditsConvas.SetActive(false);
    }

    public void showTutorial()
    {
        AkSoundEngine.PostEvent(buttonSFX.Id, this.gameObject);
        mainMenu.SetActive(false);
        tutorialConvas.SetActive(true);
    }

    public void hideTutorial()
    {
        AkSoundEngine.PostEvent(buttonSFX.Id, this.gameObject);
        mainMenu.SetActive(true);
        tutorialConvas.SetActive(false);
    }
    public void QuitGame()
    {
        Debug.Log("Spiel wurde beendet!!");
        Application.Quit();
    }
}
