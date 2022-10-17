using UnityEngine;

public class BallFunctionalities : MonoBehaviour
{
    public float travelSpeed;

    private void Update() {
        if(travelSpeed != 0)
        {
            transform.position -= -transform.forward * Time.deltaTime * travelSpeed;
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "Hand")
        {
            GameCondition.thisInstance.hitScore++;
            UITextReference.uiInstance.hitScore.text = GameCondition.thisInstance.hitScore.ToString();
        }
        else
        {
            GameCondition.thisInstance.missScore++;
            UITextReference.uiInstance.missScore.text = GameCondition.thisInstance.missScore.ToString();
        }
        Destroy(transform.gameObject);
        GameCondition.thisInstance.GameReady(true);
    }
}
