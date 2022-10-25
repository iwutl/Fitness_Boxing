using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TutorialTaskFunctionalities : MonoBehaviour
{
    public static TutorialTaskFunctionalities createInstance;
    public Animator characterAnimation;
    public GameObject[] tutorialTasks, createObject;
    public GameObject currentID, currentBall;
    public Transform spawnPoint;
    public bool canStart;
    public int currentObject;
    int currentTask;

    private void Awake() {
        if(createInstance == null)
        {
            createInstance = this;
        }
    }

    private void Start()
    {
        TaskUpdate(0);
        currentID.SetActive(false);
        canStart = false;
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

    public void AnimatedCharacter(int count)
    {
        StartCoroutine(AnimationWait(count));
    }

    IEnumerator AnimationWait(int count)
    {
        characterAnimation.SetInteger("currentState", 0);
        yield return new WaitForSeconds(0.2f);
        characterAnimation.SetInteger("currentState", count);
    }

    public void StartFiring(bool state)
    {
        canStart = state;
    }

    public void Firing(int count)
    {
        currentObject = count;
        switch(currentObject)
        {
            case 0:
            currentBall = Instantiate(createObject[currentObject], spawnPoint.position, spawnPoint.rotation);
            break;
            case 1:
            currentBall = Instantiate(createObject[currentObject], spawnPoint.position, spawnPoint.rotation);
            break;
            case 2:
            currentBall = Instantiate(createObject[currentObject], spawnPoint.position, spawnPoint.rotation);
            break;
            case 3:
            currentBall = Instantiate(createObject[currentObject], spawnPoint.position, spawnPoint.rotation);
            break;
        }
        
    }

    public void BallDestroy()
    {
        Destroy(currentBall);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
