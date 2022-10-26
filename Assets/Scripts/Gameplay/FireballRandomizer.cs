using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballRandomizer : MonoBehaviour
{
    [Header("Input")]
    public Transform[] firingTarget,firingPoints,sitTarget;
    public GameObject[] firePrefab,logPrefab;
    public int sampleScale;
    float spawnTime;

    [Header("Output")]
    public int currentPos;
    public List<int> firingType;
    public GameObject currentBall;

    void Start()
    {
        for(int i=0;i<sampleScale;i++)
        {
            for(int j=0;j<firingPoints.Length;j++)
            {
                firingType.Add(j);
            }

            firingType.Add(-1);
        }

        for(int i = 0; i < firingPoints.Length; i++)
        {
            firingPoints[i].LookAt(firingTarget[1]); // only the centre point (current element 1)
        }
        
        for(int i=0 ; i< sitTarget.Length;i++)
        {
            sitTarget[i].LookAt(firingTarget[i]); // all elements
        }
    }

    void BallSpawner()
    {
        spawnTime += Time.deltaTime;
        if(spawnTime >= 1)
        {
            spawnTime = 0;
            RandomFire();
        }
    }

    void Update()
    {
        BallSpawner();
    }

    public void RandomFire()
    {
        if(GameCondition.gameInstance.isGameReady && !GameCondition.gameInstance.isGameEnd)
        {
            int tempPos = Random.Range(0,firingType.Count);
            currentPos = firingType[tempPos];

            if(currentPos>=0)
            {
                int randomBall = Random.Range(0,firePrefab.Length);

                currentBall = Instantiate(firePrefab[randomBall],firingPoints[currentPos].position,firingPoints[currentPos].rotation);

                GameCondition.gameInstance.totalBallSpawned++;
                PlayerPrefs.SetString("totalBallSpawned", GameCondition.gameInstance.totalBallSpawned.ToString());
            }
            else
            {
                int randomLog = Random.Range(0,logPrefab.Length);

                currentBall = Instantiate(logPrefab[randomLog], sitTarget[randomLog].position,(sitTarget[randomLog].rotation * logPrefab[randomLog].transform.rotation));

                GameCondition.gameInstance.totalBlockSpawned++;
                PlayerPrefs.SetString("totalBlockSpawned", GameCondition.gameInstance.totalBlockSpawned.ToString());
            }
        }
    }
}
