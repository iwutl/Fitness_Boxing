using UnityEngine;
using TMPro;

public class UITextReference : MonoBehaviour
{
    public static UITextReference uiInstance;
    public TextMeshProUGUI hitScore, missScore;

    private void Awake() {
        if(uiInstance == null)
        {
            uiInstance = this;
        }
    }
}
