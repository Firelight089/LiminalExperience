using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SateliteRotation : MonoBehaviour
{
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, 0.5f * Time.deltaTime);
    }
}
