using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    [SerializeField]
    GameObject paintCube;

    [SerializeField]
    Material brushMaterial;
    [SerializeField]
    Material paintMaterial;

    void Start()
    {
        GetComponent<Renderer>().material = brushMaterial;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            paintCube.GetComponentInChildren<Renderer>().material = paintMaterial;
            GameObject tmp = Instantiate(paintCube, transform.parent.position, transform.parent.rotation);
            float rotationCurrent = transform.parent.eulerAngles.y;
            float normalizeRotation = Mathf.FloorToInt((rotationCurrent / 30))*30;
            tmp.transform.rotation = Quaternion.Euler(tmp.transform.rotation.x, Mathf.Abs(normalizeRotation), tmp.transform.rotation.z);
        }
    }
}
