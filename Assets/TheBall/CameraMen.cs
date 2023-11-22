using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMen : MonoBehaviour
{
    public GameObject Ball;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(7.33f, 2.62f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Ball.transform.position + offset;
    }
}
