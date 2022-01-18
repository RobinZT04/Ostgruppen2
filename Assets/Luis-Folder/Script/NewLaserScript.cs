using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewLaserScript : MonoBehaviour
{

    private LineRenderer lr;
    [SerializeField]
    private Transform startPoint; // Point where the laser starts 

     void Start()
    {
        lr = GetComponent<LineRenderer>();
    }


    void Update()
    {
        lr.SetPosition(0, startPoint.position); // we sett the position of the laser in the startPoint
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
        if (hit.transform != null) // 
        {
            if (hit.collider) // If we hit something 
            {
                lr.SetPosition(1, hit.point); // the position to our laser, it goes from point 0 to point 1 
            }
            if (hit.transform.tag == "Player") // if we hit something with the tag player 
            {
                Destroy(hit.transform.gameObject); // 
            }
        }
        else lr.SetPosition(1, transform.right * 10); // if we don't hit something the laser wont go forever and will stop after the distance i put in.
       

    }



}
