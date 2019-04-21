using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour {
    public float speed = 5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xRotacion = Input.GetAxis("Vertical");
        float zRotacion = Input.GetAxis("Horizontal");
        transform.Rotate(xRotacion, 0f, -zRotacion);
    }
}
