using UnityEngine;

public class TutHand : MonoBehaviour
{
    public GameObject destroyBalls;
    private void OnCollisionEnter(Collision other) {
        ObjectCondition(other);
    }

    private void OnCollisionStay(Collision other) {
        ObjectCondition(other);
    }

    void ObjectCondition(Collision other)
    {
        if(other.transform.tag == "BallHit")
        {
            Instantiate(destroyBalls, other.GetContact(0).point, Quaternion.identity);
            Destroy(other.gameObject);
            TutorialTaskFunctionalities.createInstance.Firing(0);
        }
    }
}
