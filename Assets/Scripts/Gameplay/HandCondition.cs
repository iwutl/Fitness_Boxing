using UnityEngine;

public enum PlayerHand{
    left, right, none
};

public class HandCondition : MonoBehaviour
{
    public PlayerHand currentHand;
    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "BallHit")
        {
            if(currentHand == PlayerHand.left)
            {
                GameCondition.gameInstance.leftHandScore++;
                UITextReference.uiInstance.leftHandScore.text = GameCondition.gameInstance.leftHandScore.ToString();
            }
            else if(currentHand == PlayerHand.right )
            {
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
        Destroy(transform.gameObject);
        GameCondition.gameInstance.GameReady(true);
    }
}
