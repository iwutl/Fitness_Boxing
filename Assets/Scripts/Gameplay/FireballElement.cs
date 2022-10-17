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
            GameCondition.gameInstance.rightHitScore++;
            UITextReference.uiInstance.rightHitScore.text = GameCondition.gameInstance.rightHitScore.ToString();
        }
        else if(other.transform.tag == "LeftHand")
        {
            GameCondition.gameInstance.leftHitScore++;
            UITextReference.uiInstance.leftHitScore.text = GameCondition.gameInstance.leftHitScore.ToString();
        }
        else 
        {
            GameCondition.gameInstance.sitScore++;
            UITextReference.uiInstance.sitScore.text = GameCondition.gameInstance.sitScore.ToString();
        }
        Destroy(transform.gameObject);
        GameCondition.gameInstance.GameReady(true);
    }
}
