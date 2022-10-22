using UnityEngine;

public class ObjectExplosion : MonoBehaviour
{
    float min, max, rad, desDel;

    void OnEnable()
    {
        min = 10f;
        max = 20f;
        rad = 3f;
        desDel = 1f;

        foreach(Transform currentTransform in transform)
        {
            Rigidbody box = currentTransform.GetComponent<Rigidbody>();
            box.constraints = RigidbodyConstraints.None;

            if(box != null)
            {
                box.AddExplosionForce(Random.Range(min, max), transform.position, rad);
            }

            Destroy(this.gameObject, desDel);
        }
    }
}
