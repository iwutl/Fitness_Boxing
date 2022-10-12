using UnityEngine;
using System.Collections;
using TMPro;

public class TutorialTaskFunctionalities : MonoBehaviour
{
    public GameObject[] tutorialTasks;
    public TextMeshProUGUI taskTimerDisplay;
    int tutorialTaskTime, taskID;
    
    private void Start() {
        TimerReset();
        taskID = 0;
    }

    void TimerReset()
    {
        tutorialTaskTime = 5;
        taskTimerDisplay.text = tutorialTaskTime.ToString();
    }

    void TimerStarted()
    {
        tutorialTaskTime --;
        taskTimerDisplay.text = tutorialTaskTime.ToString();
        if(tutorialTaskTime < 1)
        {
            tutorialTaskTime = 0;
            taskID ++;
        }
    }

    void TaskUpdate(int count)
    {
        TimerStarted();
        for(int i = 0; i < tutorialTasks.Length; i++)
        {
            if(i == count)
            {
                tutorialTasks[i].SetActive(true);
            }
            else
            {
                tutorialTasks[i].SetActive(false);
            }
        }
    }

    IEnumerator CountDownAction()
    {
        while(tutorialTaskTime > 0)
        {   
            yield return new WaitForSeconds(1.5f);
            TaskUpdate(taskID);
        }
    }

    public void TutorialStarted()
    {
        StartCoroutine(CountDownAction());
    }
}
