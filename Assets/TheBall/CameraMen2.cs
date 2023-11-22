using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMen2 : MonoBehaviour
{
    public GameObject Ball;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(11.8f, 3.2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Ball.transform.position + offset;
    }
}
