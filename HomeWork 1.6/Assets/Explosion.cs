using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float Radius;
    public float Force;
    // Start is called before the first frame update
    void Start()
    {
        Collider[] colliders =Physics.OverlapSphere(transform.position, Radius);

        for(int i = 0; i < colliders.Length; i++)
        {
            Rigidbody rigidbody = colliders[i].attachedRigidbody;
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(Force, transform.position, Radius);
            }
        }
    }

    // Update is called once per frame
  
}
