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

        PlayerPrefs.SetString("leftHandScore", "0");
        PlayerPrefs.SetString("rightHandScore", "0");
        PlayerPrefs.SetString("ballMissedScore", "0");
        PlayerPrefs.SetString("blockSitScore", "0");
        PlayerPrefs.SetString("blockStrifeScore", "0");
        PlayerPrefs.SetString("totalBallSpawned", "0");
        PlayerPrefs.SetString("totalBlockSpawned", "0");
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
