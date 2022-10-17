using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameCondition : MonoBehaviour
{
    public static GameCondition thisInstance;
    public GameObject ball, currentBall;
    public List<Transform> spawnPosition;
    public int hitScore, missScore;
    public bool isGameReady, isGameEnd;
    Transform parentObject;

    private void Awake() {
        if(thisInstance == null)
        {
            thisInstance = this;
        }

        hitScore = 0;
        missScore = 0;

        parentObject = GetComponent<Transform>();
        
        for(int i = 0; i < parentObject.childCount; i++)
        {
            spawnPosition.Add (parentObject.GetChild(i));
        }
    }

    public void GameReady(bool state)
    {
        isGameReady = state;
    }

    public void GameEnd(bool state)
    {
        isGameEnd = state;
    }

    private void Update() {
        if(isGameReady)
        {
            int randomNo = Random.Range(0, spawnPosition.Count);
            currentBall = GameObject.Instantiate(ball, spawnPosition[randomNo].position, spawnPosition[randomNo].rotation);
            GameReady(false);
        }
        if(isGameEnd)
        {
            Destroy(currentBall);
            GameEnd(false);
        }
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
