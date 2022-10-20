using UnityEngine;
using TMPro;

public class UITextReference : MonoBehaviour
{
    public static UITextReference uiInstance;
    public TextMeshProUGUI leftHandScore, rightHandScore, blockSitScore, blockStrifeScore;

    private void Awake() {
        if(uiInstance == null)
        {
            uiInstance = this;
        }
    }
}
