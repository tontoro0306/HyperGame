using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCube : MonoBehaviour
{
    [SerializeField]
    GameObject effect;

    private void Start()
    {
        Instantiate(effect,transform.position,transform.rotation);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PaintCube")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
