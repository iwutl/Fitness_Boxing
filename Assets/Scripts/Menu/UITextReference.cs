using UnityEngine;
using TMPro;

public class UITextReference : MonoBehaviour
{
    public static UITextReference uiInstance;

    [Header("On-Screen Content" + "\n" + "\n" + "1. Left Hand" + "\n" + "2. Right Hand" + "\n" + "3. Sitting"+ "\n" + "4. Strife" + "\n")]
    public TextMeshProUGUI[] playingDisplay;
    [Header("Floating Diplay Content" + "\n" + "\n" + "1. Total Ball" + "\n" + "2. Left Hand" + "\n" + "3. Right Hand" + "\n" + "4. Total Block" + "\n" + "5. Sitting"+ "\n" + "6. Strife" + "\n" + "7. Missed Ball" + "\n" + "8. Body Hit" + "\n")]
    public TextMeshProUGUI[] resultDisplay;

    private void Awake() {
        if(uiInstance == null)
        {
            uiInstance = this;
        }
    }

    public void ResultUpdate()
    {
        resultDisplay[0].text = PlayerPrefs.GetString("totalBallSpawned");
        resultDisplay[1].text = PlayerPrefs.GetString("leftHandScore");
        resultDisplay[2].text = PlayerPrefs.GetString("rightHandScore");
        resultDisplay[3].text = PlayerPrefs.GetString("totalBlockSpawned");
        resultDisplay[4].text = PlayerPrefs.GetString("blockSitScore");
        resultDisplay[5].text = PlayerPrefs.GetString("blockStrifeScore");
        resultDisplay[6].text = PlayerPrefs.GetString("ballMissedScore");
        resultDisplay[7].text = PlayerPrefs.GetString("blockHandScore");
    }
}
