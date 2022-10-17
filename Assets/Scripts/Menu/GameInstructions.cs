using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    public GameObject[] gameInstruction;
    int currentPage;

    private void Awake() {
        PageLoad(currentPage);
    }

    public void PageLoad(int count)
    {
        currentPage = count;
        for(int i = 0; i < gameInstruction.Length; i++)
        {
            if(i == count)
            {
                gameInstruction[i].SetActive(true);
            }
            else
            {
                gameInstruction[i].SetActive(false);
            }
        }
    }
}
