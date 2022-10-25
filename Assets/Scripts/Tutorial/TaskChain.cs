using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TaskChain : MonoBehaviour
{
    public GameObject fireBall;
    public Transform moveParent;
    public float travelSpeed;
    public Transform[] movePoint;
    public Vector3[] points, tempPoint;
    LTBezierPath pathPoint;

    private void OnEnable() {
        movePoint = new Transform[moveParent.childCount];
        points = new Vector3[moveParent.childCount];
        tempPoint = new Vector3[moveParent.childCount];
        fireBall.SetActive(true);

        for(int i = 0; i < moveParent.childCount; i++)
        {
            movePoint[i] = moveParent.GetChild(i);
        }

        StartCoroutine(PathLoop());
    }

    IEnumerator PathLoop()
    {
        for(int i = 0; i < movePoint.Length; i++)
        {
            points[i] = movePoint[i].position;
        }

        for(int i = movePoint.Length - 1; i >= 0; i--)
        {
            tempPoint[movePoint.Length - 1 - i] = movePoint[i].position;
        }
        
        pathPoint = new LTBezierPath(points);
        LTDescr tweenPath = LeanTween.move(fireBall, pathPoint, travelSpeed);
        pathPoint = new LTBezierPath(tempPoint);
        LTDescr tweenPathReverse = LeanTween.move(fireBall, pathPoint, travelSpeed).setDelay(travelSpeed);

        yield return new WaitForSeconds(travelSpeed);

        pathPoint = new LTBezierPath(points);
        LTDescr tweenPathOne = LeanTween.move(fireBall, pathPoint, travelSpeed);
        pathPoint = new LTBezierPath(tempPoint);
        LTDescr tweenPathReverseOne = LeanTween.move(fireBall, pathPoint, travelSpeed).setDelay(travelSpeed);
        
        yield return new WaitForSeconds(travelSpeed);

        pathPoint = new LTBezierPath(points);
        LTDescr tweenPathTwo = LeanTween.move(fireBall, pathPoint, travelSpeed);
        pathPoint = new LTBezierPath(tempPoint);
        LTDescr tweenPathReverseTwo = LeanTween.move(fireBall, pathPoint, travelSpeed).setDelay(travelSpeed);

        yield return new WaitForSeconds(travelSpeed);
    }
}
