using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using TMPro;

public class GameBegin : MonoBehaviour
{
    public TextMeshProUGUI countDownText;
    int countDownTimer;
    bool startTimer;
    public UnityEvent afterCountDown;

    private void Awake() {
        countDownTimer = 3;
        countDownText.text = countDownTimer.ToString();
        startTimer = false;
        StartTheGame();
    }

    void GameTimerInitialize()
    {
        countDownTimer--;
        if(countDownTimer < 1)
        {
            countDownTimer = 0;
            countDownText.transform.parent.gameObject.SetActive(false);
            startTimer = true;
            afterCountDown.Invoke();
        }
        countDownText.text = countDownTimer.ToString();
    }

    IEnumerator CountDownAction()
    {
        while(countDownTimer > 0)
        {
            yield return new WaitForSeconds(0.1f);

            LeanTween.scale(countDownText.gameObject, new Vector3(1.5f, 1.5f, 1f), 0.5f).setDelay(0.25f).setEase(LeanTweenType.easeOutElastic);

            yield return new WaitForSeconds(1f);

            LeanTween.scale(countDownText.gameObject, new Vector3(0, 0, 0), 0.5f).setDelay(0.25f).setEase(LeanTweenType.easeInBack);
            
            yield return new WaitForSeconds(1f);

            GameTimerInitialize();
        }
    }

    public void StartTheGame()
    {
        StartCoroutine(CountDownAction());
    }
}
