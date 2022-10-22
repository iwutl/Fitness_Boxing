using UnityEngine;

public enum PlayerHand{
    left, right, none
};

public class HandCondition : MonoBehaviour
{
    public PlayerHand currentHand;
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
            if(currentHand == PlayerHand.left)
            {
                GameCondition.gameInstance.leftHandScore++;
                PlayerPrefs.SetString("leftHandScore", GameCondition.gameInstance.leftHandScore.ToString());
                UITextReference.uiInstance.playingDisplay[0].text = GameCondition.gameInstance.leftHandScore.ToString();
            }
            else if(currentHand == PlayerHand.right )
            {
                GameCondition.gameInstance.rightHandScore++;
                PlayerPrefs.SetString("rightHandScore", GameCondition.gameInstance.rightHandScore.ToString());
                UITextReference.uiInstance.playingDisplay[1].text = GameCondition.gameInstance.rightHandScore.ToString();
            }
            else if(currentHand == PlayerHand.none )
            {
                GameCondition.gameInstance.ballMissedScore++;
                PlayerPrefs.SetString("ballMissedScore", GameCondition.gameInstance.ballMissedScore.ToString());
            }
        }
        else if(other.transform.tag == "BlockSit")
        {
            if(currentHand == PlayerHand.left)
            {
                GameCondition.gameInstance.blockHandScore++;
                PlayerPrefs.SetString("blockHandScore", GameCondition.gameInstance.blockHandScore.ToString());
            }
            else if(currentHand == PlayerHand.right )
            {
                GameCondition.gameInstance.blockHandScore++;
                PlayerPrefs.SetString("blockHandScore", GameCondition.gameInstance.blockHandScore.ToString());
            }
            else if(currentHand == PlayerHand.none )
            {
                GameCondition.gameInstance.blockSitScore++;
                UITextReference.uiInstance.playingDisplay[2].text = GameCondition.gameInstance.blockSitScore.ToString();
                PlayerPrefs.SetString("blockSitScore", GameCondition.gameInstance.blockSitScore.ToString());
            }
        }
        else if(other.transform.tag == "BlockStand")
        {
            if(currentHand == PlayerHand.left)
            {
                GameCondition.gameInstance.blockHandScore++;
                PlayerPrefs.SetString("blockHandScore", GameCondition.gameInstance.blockHandScore.ToString());
            }
            else if(currentHand == PlayerHand.right )
            {
                GameCondition.gameInstance.blockHandScore++;
                PlayerPrefs.SetString("blockHandScore", GameCondition.gameInstance.blockHandScore.ToString());
            }
            else if(currentHand == PlayerHand.none )
            {
                GameCondition.gameInstance.blockStrifeScore++;
                UITextReference.uiInstance.playingDisplay[3].text = GameCondition.gameInstance.blockStrifeScore.ToString();
                PlayerPrefs.SetString("blockStrifeScore", GameCondition.gameInstance.blockStrifeScore.ToString());
            }
        }
        Destroy(other.gameObject);
        GameCondition.gameInstance.GameReady(true);
    }
}
