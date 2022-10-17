using UnityEngine;
using TMPro;

public class UITextReference : MonoBehaviour
{
    public static UITextReference uiInstance;
    public TextMeshProUGUI leftHitScore, rightHitScore, sitScore;

    private void Awake() {
        if(uiInstance == null)
        {
            uiInstance = this;
        }
    }
}
