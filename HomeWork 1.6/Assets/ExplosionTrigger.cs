using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
    private int count = 0;
    private void OnTriggerEnter(Collider other)
    {
        count++;
        if (count <= 1)
            Debug.Log("There was an explosion");
        else
            return;
    }
}
