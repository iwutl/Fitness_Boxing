using UnityEngine;
using TMPro;

public class UITextReference : MonoBehaviour
{
    public static UITextReference uiInstance;
    public TextMeshProUGUI leftHandScore, rightHandScore, blockSitScore, blockStrifeScore;
    public TextMeshProUGUI resultLeftHand, resultRightHand, resultSit, resultStrife;

    private void Awake() {
        if(uiInstance == null)
        {
            uiInstance = this;
        }
    }

    public void ResultUpdate()
    {
        resultLeftHand.text = PlayerPrefs.GetString("leftHandScore");
        resultRightHand.text = PlayerPrefs.GetString("rightHandScore");
        resultSit.text = PlayerPrefs.GetString("blockSitScore");
        resultStrife.text = PlayerPrefs.GetString("blockStrifeScore");
    }
}
