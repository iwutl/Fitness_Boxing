using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballElement : MonoBehaviour
{
    public float speed;
    public float timer;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        timer -= Time.deltaTime;
        if(timer <= 0 )
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {        
        
    }
}
