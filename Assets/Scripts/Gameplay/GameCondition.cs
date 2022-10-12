using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameCondition : MonoBehaviour
{
    public static GameCondition thisInstance;
    public GameObject ball;
    public List<Transform> spawnPosition;
    public int hitScore, missScore, bodyHit;
    public bool isGameReady;
    Transform parentObject;
    float spawnInterval;
    

    private void Awake() {
        if(thisInstance == null)
        {
            thisInstance = this;
        }

        spawnInterval = 3f;
        hitScore = 0;
        missScore = 0;
        bodyHit = 0;

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

    private void Update() {
        if(isGameReady)
        {
            int randomNo = Random.Range(0, spawnPosition.Count);
            GameObject currentBall = GameObject.Instantiate(ball, spawnPosition[randomNo].position, spawnPosition[randomNo].rotation);
            GameReady(false);
        }
    }
}
