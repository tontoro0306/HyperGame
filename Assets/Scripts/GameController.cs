using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    float speed=200;

    [SerializeField]
    GameObject cube;

    bool isActive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed* Time.deltaTime,0);
        if (Input.GetMouseButtonDown(0) && isActive) {
            Instantiate(cube);
            speed = 0;
            isActive = false;
        }
    }
}
