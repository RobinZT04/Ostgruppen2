using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// OBS! DET HÄR SCRIPTET ANVÄNDES BARA VID SKAPANDET AV PUSSLET OCH ANVÄNDS INTE LÄNGRE - Henry
public class TestPlayerMove : MonoBehaviour
{
    Rigidbody2D testrb;

    // Start is called before the first frame update
    void Start()
    {
        testrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            testrb.velocity = new Vector2(0, 4);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            testrb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            testrb.velocity = new Vector2(-4, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            testrb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            testrb.velocity = new Vector2(4, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            testrb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            testrb.velocity = new Vector2(0, -4);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            testrb.velocity = new Vector2(0, 0);
        }
    }
}