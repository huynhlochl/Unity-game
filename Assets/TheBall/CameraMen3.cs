using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMen3 : MonoBehaviour
{
    public GameObject Ball;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(8.87f, 1.97f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Ball.transform.position + offset;
    }
}
