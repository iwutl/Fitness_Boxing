using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeachingGuide : MonoBehaviour
{
    public GameObject rotateBall;
    private Vector3[] circleSm = new Vector3[]{ new Vector3(16f,0f,0f), new Vector3(14.56907f,8.009418f,0f), new Vector3(15.96541f,4.638379f,0f), new Vector3(11.31371f,11.31371f,0f), new Vector3(11.31371f,11.31371f,0f), new Vector3(4.638379f,15.96541f,0f), new Vector3(8.009416f,14.56908f,0f), new Vector3(-6.993822E-07f,16f,0f), new Vector3(-6.993822E-07f,16f,0f), new Vector3(-8.009419f,14.56907f,0f), new Vector3(-4.63838f,15.9654f,0f), new Vector3(-11.31371f,11.31371f,0f), new Vector3(-11.31371f,11.31371f,0f), new Vector3(-15.9654f,4.63838f,0f), new Vector3(-14.56908f,8.009415f,0f), new Vector3(-16f,-1.398764E-06f,0f), new Vector3(-16f,-1.398764E-06f,0f), new Vector3(-14.56907f,-8.009418f,0f), new Vector3(-15.9654f,-4.638382f,0f), new Vector3(-11.31371f,-11.31371f,0f), new Vector3(-11.31371f,-11.31371f,0f), new Vector3(-4.638381f,-15.9654f,0f), new Vector3(-8.009413f,-14.56908f,0f), new Vector3(1.907981E-07f,-16f,0f), new Vector3(1.907981E-07f,-16f,0f), new Vector3(8.00942f,-14.56907f,0f), new Vector3(4.638381f,-15.9654f,0f), new Vector3(11.31371f,-11.3137f,0f), new Vector3(11.31371f,-11.3137f,0f), new Vector3(15.96541f,-4.638378f,0f), new Vector3(14.56907f,-8.009418f,0f), new Vector3(16f,2.797529E-06f,0f) };
	private Vector3[] circleLrg = new Vector3[]{ new Vector3(25f,0f,0f), new Vector3(22.76418f,12.51472f,0f), new Vector3(24.94595f,7.247467f,0f), new Vector3(17.67767f,17.67767f,0f), new Vector3(17.67767f,17.67767f,0f), new Vector3(7.247467f,24.94595f,0f), new Vector3(12.51471f,22.76418f,0f), new Vector3(-1.092785E-06f,25f,0f), new Vector3(-1.092785E-06f,25f,0f), new Vector3(-12.51472f,22.76418f,0f), new Vector3(-7.247468f,24.94594f,0f), new Vector3(-17.67767f,17.67767f,0f), new Vector3(-17.67767f,17.67767f,0f), new Vector3(-24.94594f,7.247468f,0f), new Vector3(-22.76418f,12.51471f,0f), new Vector3(-25f,-2.185569E-06f,0f), new Vector3(-25f,-2.185569E-06f,0f), new Vector3(-22.76418f,-12.51472f,0f), new Vector3(-24.94594f,-7.247472f,0f), new Vector3(-17.67767f,-17.67767f,0f), new Vector3(-17.67767f,-17.67767f,0f), new Vector3(-7.247469f,-24.94594f,0f), new Vector3(-12.51471f,-22.76418f,0f), new Vector3(2.98122E-07f,-25f,0f), new Vector3(2.98122E-07f,-25f,0f), new Vector3(12.51472f,-22.76418f,0f), new Vector3(7.24747f,-24.94594f,0f), new Vector3(17.67768f,-17.67766f,0f), new Vector3(17.67768f,-17.67766f,0f), new Vector3(24.94595f,-7.247465f,0f), new Vector3(22.76418f,-12.51472f,0f), new Vector3(25f,4.371139E-06f,0f) };


    private void Start()
    {
        LeanTween.moveLocal(rotateBall, circleLrg, 1f).setSpeed(20f).setRepeat(-1);
    }
}
