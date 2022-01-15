﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectLaser : MonoBehaviour
{
    //JOSÉ LUIS
    int maxBounces = 5;
    private LineRenderer lr;
    [SerializeField]
    private Transform startPoint;
    [SerializeField]
    private bool reflectOnlyMirror;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>(); // the linerenderer is equal to the getcomponents line render that's attached to the object 
        lr.SetPosition(0, startPoint.position); // we set the position of the laser to 0 so it will  be it's start point
    }

    // Update is called once per frame
    void Update()
    {
        CastLaser(transform.position, transform.forward); // This is the function to draw the laser 
    }


    void CastLaser(Vector2 position, Vector2 direction) 
    {
        lr.SetPosition(0, startPoint.position);

        for (int i = 0; i < maxBounces; i++) // creat a loop for each position of the laser 
        {
            Ray2D ray2D = new Ray2D(position, direction); // we creat a raycast that shoots an array in our position and in our direction. 
          //RaycastHit2D hit;
          //if(Physics2D.Raycast(ray2D, out hit, 300, 1))
            {
           //   position = hit.point; // the next position of the laser will be the hit point 
             // direction = Vector2.Reflect(direction, hit.normal);// This will calculate the angle that the laser needs to be in the next hit 
           //   lr.SetPosition(i + 1, hit.point); // we sett the position of the linerenderer in our hit 

           //   if (hit.transform.name != "Mirror" && reflectOnlyMirror) // if the object is not named mirror and we have reflectOnlyMirror the laser will stop there 
                {// Creat a loop 
                    for (int j = (i + 1); j <= 5; j++)
                    {
             //         lr.SetPosition(j, hit.point);
                    }
                    break; // break from the loop 
                }
            }
        }
    }
}
