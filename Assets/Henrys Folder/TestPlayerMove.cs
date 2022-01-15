using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerMove : MonoBehaviour
{
    Rigidbody testrb;

    // Start is called before the first frame update
    void Start()
    {
        testrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            testrb.velocity = new Vector3(0, 4, 0);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            testrb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            testrb.velocity = new Vector3(-4, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            testrb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            testrb.velocity = new Vector3(4, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            testrb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            testrb.velocity = new Vector3(0, -4, 0);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            testrb.velocity = new Vector3(0, 0, 0);
        }
    }
}
