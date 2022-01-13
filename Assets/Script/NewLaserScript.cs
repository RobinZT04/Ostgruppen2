using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLaserScript : MonoBehaviour
{

    private LineRenderer lr;
    [SerializeField]
    private Transform startPoint;


    private void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, startPoint.position); // we sett the position of our laser in our start point 
        RaycastHit2D  hit;
        if (Physics2D.Raycast(transform.position, -transform.right, out hit))
        {
            if (hit.collider) // if we hit something 
            {
                lr.SetPosition(1, hit.point); // we are the position to our laser, goes from point 0 which is the start point and then goes to point one 
            }
            if (hit.transform.tag == "Player") // if we hit the the player with the player tag
            {
                Destroy(hit.transform.gameObject); // we destroy the gameobject 
            }
        }
        else lr.SetPosition(1, -transform.right * 5000); // if the laser does not hit something it wont go forever after the distance i put here. 
    }
}
