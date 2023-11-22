using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VatCanDC2 : MonoBehaviour
{
    public int Go = 100;
    Rigidbody DC;
    // Start is called before the first frame update
    void Start()
    {
        DC = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        DC.AddForce(0, 0, -Go * Time.deltaTime);
    }
}
