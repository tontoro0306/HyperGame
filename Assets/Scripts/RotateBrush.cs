using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBrush : MonoBehaviour
{
    [SerializeField]
    float speed = 200;

    void Update()
    {
        transform.Rotate(0, speed* Time.deltaTime, 0);
    }
}
