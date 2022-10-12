using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballRandomizer : MonoBehaviour
{
    [Header("Input")]
    public Transform[] firingPoints;
    public int sampleScale;

    [Header("Output")]
    public List<int> firingType;

    void Start()
    {
        for(int i=0;i<sampleScale;i++)
        {
            for(int j=0;j<firingPoints.Length;j++)
            {
                firingType.Add(j+1);
            }

            firingType.Add(-1);
        }
    }
}
