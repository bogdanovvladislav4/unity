using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panzer : MonoBehaviour
{

    void Update()
    {
        Vector3 velocity = new Vector3(0, 0, 10);
        Vector3 motion = velocity * Time.deltaTime;

        transform.position += motion;
    }
}
