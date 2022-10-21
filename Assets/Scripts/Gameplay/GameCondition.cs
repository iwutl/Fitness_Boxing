using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameCondition : MonoBehaviour
{
    public static GameCondition gameInstance;
    public int leftHandScore, rightHandScore, ballMissedScore, blockHandScore, blockSitScore, blockStrifeScore, totalBallSpawned, totalBlockSpawned;
    public bool isGameReady, isGameEnd;

    private void Awake() {
        if(gameInstance == null)
        {
            gameInstance = this;
        }

        PlayerPrefs.SetString("leftHandScore", "");
        PlayerPrefs.SetString("rightHandScore", "");
        PlayerPrefs.SetString("ballMissedScore", "");
        PlayerPrefs.SetString("blockSitScore", "");
        PlayerPrefs.SetString("blockStrifeScore", "");
        PlayerPrefs.SetString("totalBallSpawned", "");
        PlayerPrefs.SetString("totalBlockSpawned", "");
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
