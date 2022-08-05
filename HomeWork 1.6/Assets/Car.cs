using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = new Vector3(0, 0, -15);
        Vector3 motion = velocity * Time.deltaTime;

        transform.position += motion;
    }
}
