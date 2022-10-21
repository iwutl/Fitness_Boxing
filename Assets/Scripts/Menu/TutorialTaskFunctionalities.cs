using UnityEngine;

public class TutorialTaskFunctionalities : MonoBehaviour
{
    public GameObject[] tutorialTasks;

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
}
