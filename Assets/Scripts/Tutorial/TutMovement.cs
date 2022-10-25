using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutMovement : MonoBehaviour
{
    public float speed, timer;

    void Update()
    {
        if(TutorialTaskFunctionalities.createInstance.canStart)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
            timer -= Time.deltaTime;
            if(timer <= 0 )
            {
                Destroy(this.gameObject);
                TutorialTaskFunctionalities.createInstance.Firing(TutorialTaskFunctionalities.createInstance.currentObject);
            }
        }
    }
}
