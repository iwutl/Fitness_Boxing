using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballElement : MonoBehaviour
{
    public float speed;
    public float timer;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        timer -= Time.deltaTime;
        if(timer <= 0 )
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "RightHand")
        {
            GameCondition.thisInstance.rightHitScore++;
            UITextReference.uiInstance.rightHitScore.text = GameCondition.thisInstance.rightHitScore.ToString();
        }
        else if(other.transform.tag == "LeftHand")
        {
            GameCondition.thisInstance.leftHitScore++;
            UITextReference.uiInstance.leftHitScore.text = GameCondition.thisInstance.leftHitScore.ToString();
        }
        else 
        {
            GameCondition.thisInstance.sitScore++;
            UITextReference.uiInstance.sitScore.text = GameCondition.thisInstance.sitScore.ToString();
        }
        Destroy(transform.gameObject);
        GameCondition.thisInstance.GameReady(true);
    }
}
