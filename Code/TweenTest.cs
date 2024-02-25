using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTest : MonoBehaviour
{
    public GameObject buttonPlay;
    public GameObject buttonSet;
    public GameObject buttonLevel;
    public GameObject buttonControls;
    public GameObject buttonQuit;
    public GameObject Baslik;
    public float xValue;

    private void Start()
    {
        Moved();
        Scale();
    }

    public void Moved()
    {
        LeanTween.moveLocal(Baslik, new Vector3(0f, 300f, 0f), 1.5f).setDelay(0.2f).setEase(LeanTweenType.easeOutBounce);
    }

    public void Scale()
    {
        LeanTween.scale(buttonPlay, new Vector3(1f, 1f, 1f), 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(buttonSet, new Vector3(1f, 1f, 1f), 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(buttonLevel, new Vector3(1f, 1f, 1f), 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(buttonControls, new Vector3(1f, 1f, 1f), 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(buttonQuit, new Vector3(1f, 1f, 1f), 1.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(buttonPlay, new Vector3(0f, 0f, 0f), 1.5f).setDelay(0.2f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.moveLocal(buttonSet, new Vector3(0f, -150f, 0f), 1.5f).setDelay(0.2f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.moveLocal(buttonLevel, new Vector3(0f, -300f, 0f), 1.5f).setDelay(0.2f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.moveLocal(buttonControls, new Vector3(0f, -450f, 0f), 1.5f).setDelay(0.2f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.moveLocal(buttonQuit, new Vector3(600f, -450f, 0f), 1.5f).setDelay(0.2f).setEase(LeanTweenType.easeOutBounce);

    }
}
