using UnityEngine;

public class TutorialTaskFunctionalities : MonoBehaviour
{
    public GameObject[] tutorialTasks;
    public GameObject currentID;
    int currentTask;

    private void Start()
    {
        TaskUpdate(0);
        currentID.SetActive(false);
    }

    public void TaskUpdate(int count)
    {
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

    public void TaskValue()
    {
        currentTask++;
        TaskUpdate(currentTask);
        currentID.SetActive(false);
    }
}
