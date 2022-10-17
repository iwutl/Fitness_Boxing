using System.Collections;
using UnityEngine;

public class DrumFunctionalities : MonoBehaviour
{
    public GameObject drumBase;

    public IEnumerator PunchIn()
    {
        yield return new WaitForSeconds(0.1f);

        LeanTween.moveLocal(drumBase, new Vector3(0, -1f, 0), 0.25f).setDelay(0.1f).setEase(LeanTweenType.easeOutElastic);
    }

    public IEnumerator PunchOut()
    {
        yield return new WaitForSeconds(0.05f);

        LeanTween.moveLocal(drumBase, new Vector3(0, 0.3f, 0), 0.25f).setDelay(0.1f).setEase(LeanTweenType.easeOutElastic);
        
        yield return new WaitForSeconds(0.05f);
    }
}