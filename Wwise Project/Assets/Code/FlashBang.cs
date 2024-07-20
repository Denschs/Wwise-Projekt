using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashBang : MonoBehaviour
{
    private Image WhiteImage;


    private void Start()
    {
        WhiteImage = GameObject.FindGameObjectWithTag("WhiteImage").GetComponent<Image>();
        Debug.Log("WhiteImage gefunden");
    }

    public IEnumerator WhiteFade()
    {
        WhiteImage.color = new Vector4(255, 255, 255, 255);

        float FadeSpeed = 1f;
        float Modifier = 0.01f;
        float WaitTime = 0;

        for (int i = 0; WhiteImage.color.a > 0; i++)
        {
            WhiteImage.color = new Vector4(1, 1, 1, FadeSpeed);
            FadeSpeed = FadeSpeed - 0.025f;
            Modifier = Modifier * 1.5f;
            WaitTime = 0.5f - Modifier;
            if (WaitTime < 0.1f) WaitTime = 0.1f;
            yield return new WaitForSeconds(WaitTime);
        }
    }
}