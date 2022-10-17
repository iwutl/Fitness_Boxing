using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballRandomizer : MonoBehaviour
{
    [Header("Input")]
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
    }

    void Update()
    {
        if(currentBall==null)
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
            currentBall = Instantiate(firePrefab[1],firingPoints[1].position,(firingPoints[1].rotation * firePrefab[1].transform.rotation));
        }

    }
}
