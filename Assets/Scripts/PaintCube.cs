using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCube : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PaintCube")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
