using UnityEngine;

public class ObjectExplosion : MonoBehaviour
{
    float min, max, rad, desDel;

    private void Start() {
        min = 10f;
        max = 50f;
        rad = 1.0f;
        desDel = 0.5f;
    }

    void Awake()
    {
        foreach(Transform t in transform)
        {
            Rigidbody box = t.GetComponent<Rigidbody>();
            box.constraints = RigidbodyConstraints.None;

            if(box != null)
            {
                box.AddExplosionForce(Random.Range(min, max), transform.position, rad);
            }

            Destroy(t.gameObject, desDel);
        }
    }
}
