using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballRandomizer : MonoBehaviour
{
    [Header("Input")]
    public Transform firingTarget, sitTarget;
    public Transform[] firingPoints;
    public GameObject[] firePrefab;
    public int sampleScale;

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
            firingPoints[i].LookAt(firingTarget);
        }
        sitTarget.LookAt(firingTarget);
    }

    void Update()
    {
        if(currentBall == null && GameCondition.gameInstance.isGameReady && !GameCondition.gameInstance.isGameEnd)
        {
            RandomFire();
        }
    }

    public void RandomFire()
    {
        int tempPos = Random.Range(0,firingType.Count);
        currentPos = firingType[tempPos];

        if(currentPos>=0)
        {
            currentBall = Instantiate(firePrefab[0],firingPoints[currentPos].position,firingPoints[currentPos].rotation);
        }
        else
        {
            currentBall = Instantiate(firePrefab[1], sitTarget.position,(sitTarget.rotation * firePrefab[1].transform.rotation));
        }
    }
}
