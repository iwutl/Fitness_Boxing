using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float totalGameTime;
    public bool timerIsRunning;
    public TextMeshProUGUI timeText;
    public UnityEvent gameEndCheck;

    public void GameInitiate()
    {
        timerIsRunning = true;
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
    private void Update() 
    {
        if (timerIsRunning)
        {
            if (totalGameTime > 0)
            {
                totalGameTime -= Time.deltaTime;
                DisplayTime(totalGameTime);
            }
            else
            {
                totalGameTime = 0;
                timerIsRunning = false;
                gameEndCheck.Invoke();
            }
        }
    }
}
