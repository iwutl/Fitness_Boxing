using UnityEngine;

public enum PlayerHand{
    left, right, none
};

public class HandCondition : MonoBehaviour
{
    public PlayerHand currentHand;
    public GameObject destroyBalls;
    public Transform parentObject;
    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "BallHit")
        {
            if(currentHand == PlayerHand.left)
            {
                //GameObject create = Instantiate(destroyBalls);
                //create.transform.SetParent(parentObject);
                //create.transform.localPosition = parentObject.transform.localPosition;
                //create.transform.localRotation = Quaternion.identity;
                //create.transform.localScale = new Vector3(1, 1, 1);
                GameCondition.gameInstance.leftHandScore++;
                UITextReference.uiInstance.leftHandScore.text = GameCondition.gameInstance.leftHandScore.ToString();
            }
            else if(currentHand == PlayerHand.right )
            {
                //GameObject create = Instantiate(destroyBalls);
                //create.transform.SetParent(parentObject);
                GameCondition.gameInstance.rightHandScore++;
                UITextReference.uiInstance.rightHandScore.text = GameCondition.gameInstance.rightHandScore.ToString();
            }
            else if(currentHand == PlayerHand.none )
            {
                GameCondition.gameInstance.ballMissedScore++;
            }
        }
        else if(other.transform.tag == "BlockSit")
        {
            if(currentHand == PlayerHand.left)
            {
                GameCondition.gameInstance.blockHandScore++;
            }
            else if(currentHand == PlayerHand.right )
            {
                GameCondition.gameInstance.blockHandScore++;
            }
            else if(currentHand == PlayerHand.none )
            {
                GameCondition.gameInstance.blockSitScore++;
                UITextReference.uiInstance.blockSitScore.text = GameCondition.gameInstance.blockSitScore.ToString();
            }
        }
        else if(other.transform.tag == "BlockStand")
        {
            if(currentHand == PlayerHand.left)
            {
                GameCondition.gameInstance.blockHandScore++;
            }
            else if(currentHand == PlayerHand.right )
            {
                GameCondition.gameInstance.blockHandScore++;
            }
            else if(currentHand == PlayerHand.none )
            {
                GameCondition.gameInstance.blockStrifeScore++;
            }
        }
        Destroy(other.transform.gameObject);
        GameCondition.gameInstance.GameReady(true);
    }
}
