using UnityEngine;

public class DragonCondition : MonoBehaviour
{
    public Transform playerPosition;
    Animator dragon_Action;

    private void Awake() {
        dragon_Action = GetComponent<Animator>();
        dragon_Action.SetBool("StartFiring", false);
    }

    void FiringState()
    {
        dragon_Action.SetBool("StartFiring", true);
    }

    private void Update()
    {
        transform.LookAt(playerPosition);
    }
}
