using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using TMPro;

public class PageUpdateActivation : MonoBehaviour
{
    public TextMeshProUGUI countDownText;
    int countDownTimer;
    public UnityEvent preCountDown, afterCountDown;

    private void Awake()
    {
        countDownTimer = 2;
        countDownText.text = countDownTimer.ToString();
        preCountDown.Invoke();
        NextTask();
    }

    void TaskTimerInitialize()
    {
        countDownTimer--;
        if (countDownTimer < 1)
        {
            countDownTimer = 0;
            afterCountDown.Invoke();
        }
        countDownText.text = countDownTimer.ToString();
    }

    IEnumerator CountDownAction()
    {
        while (countDownTimer > 0)
        {
            yield return new WaitForSeconds(0.5f);

            LeanTween.scale(countDownText.gameObject, new Vector3(1.5f, 1.5f, 1f), 0.5f).setDelay(0.25f).setEase(LeanTweenType.easeOutElastic);

            yield return new WaitForSeconds(1f);

            LeanTween.scale(countDownText.gameObject, new Vector3(0, 0, 0), 0.5f).setDelay(0.25f).setEase(LeanTweenType.easeInBack);

            yield return new WaitForSeconds(1f);

            TaskTimerInitialize();
        }
    }

    public void NextTask()
    {
        StartCoroutine(CountDownAction());
    }
}
