using UnityEngine;

public class HandCondition : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.GetComponent<DrumFunctionalities>())
        {
            StartCoroutine(other.GetComponent<DrumFunctionalities>().PunchIn());
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.GetComponent<DrumFunctionalities>())
        {
            StartCoroutine(other.GetComponent<DrumFunctionalities>().PunchOut());
        }
    }
}
