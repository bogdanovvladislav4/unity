using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = new Vector3(0, 0, 1);
        Vector3 motion = velocity * Time.deltaTime;

        transform.position += motion;
    }
}
