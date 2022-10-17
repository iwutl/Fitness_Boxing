using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameCondition : MonoBehaviour
{
    public static GameCondition thisInstance;
    public int leftHitScore, rightHitScore, sitScore;
    public bool isGameReady, isGameEnd;

    private void Awake() {
        if(thisInstance == null)
        {
            thisInstance = this;
        }

        leftHitScore = 0;
        rightHitScore = 0;
        sitScore = 0;
    }

    public void GameReady(bool state)
    {
        isGameReady = state;
    }

    public void GameEnd(bool state)
    {
        isGameEnd = state;
    }

    public void GameEndQuit()
    {
        Application.Quit();
    }

    IEnumerator FadeoutEffect(GameObject current)
    {
        yield return new WaitForSeconds(0.1f);

        LeanTween.scale(current, new Vector3(0, 0, 0), 0.5f).setDelay(0.25f).setEase(LeanTweenType.easeInBack);
    }

    IEnumerator FadeInEffect(GameObject current)
    {
        yield return new WaitForSeconds(0.1f);

        LeanTween.scale(current, new Vector3(1f, 1f, 1f), 0.5f).setDelay(0.25f).setEase(LeanTweenType.easeOutElastic);
    }

    public void DisplayOn(GameObject current)
    {
        StartCoroutine(FadeInEffect(current));
    }

    public void DisplayOff(GameObject current)
    {
        StartCoroutine(FadeoutEffect(current));
    }
}
