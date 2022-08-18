using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMultiplication : MonoBehaviour
{
    public Transform V1;
    public Transform V2;


    private void OnDrawGizmos()
    {
        if (V1 == null || V2 == null) return;

        Gizmos.color = Color.red;
        Vector3 vector1 = V1.position;
        DrawVector(transform.position, vector1);

        Gizmos.color = Color.green;
        Vector3 vector2 = V2.position;
        DrawVector(transform.position, vector2);

        Vector3 cross = Vector3.Cross(vector1, vector2);
        Gizmos.color = Color.blue;
        DrawVector(transform.position, cross);

    }

    private void DrawVector(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector);
        Gizmos.DrawSphere(start, 0.25f);
    }
}
