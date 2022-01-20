using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


 // Made by José Luis SU20A
public class LaserBeam 
{
    Vector2 pos, dir;

   public GameObject laserObj;
    LineRenderer laser;
    List<Vector2> laserIndices = new List<Vector2>(); // make a list to store vector3's to store each point of the laser beam

    Dictionary<string, float> refractiveMaterials = new Dictionary<string, float>()
{
      {"Air", 1.0f}, // give it an idex value of one
      {"Glass", 1.5f } // give it an idex value of 1.5
    };
    public LaserBeam(Vector2 pos, Vector2 dir, Material material)
    {
        this.laser = new LineRenderer();
        this.laserObj = new GameObject();
        this.laserObj.name = "Laser Beam";
        this.pos = pos;
        this.dir = dir;

        this.laser = this.laserObj.AddComponent(typeof(LineRenderer)) as LineRenderer; //we add the linerenderer to the gameobject that we creat every time a laserbeam is created
        // we sett the color of the line renderer along with the material and the width 
        this.laser.startWidth = 0.1f; 
        this.laser.endWidth = 0.1f;
        this.laser.material = material;
        this.laser.startColor = Color.red;
        this.laser.endColor = Color.red;

        CastRay(pos, dir, laser); // where we add the starting position of the laserpointer to the laser indices list
    }


    void CastRay(Vector2 pos, Vector2 dir, LineRenderer laser) // we creat a new method called cast ray. The method i creat will have two vector3 parameters being the position and direction, also going to have a line renderer parameter being the laser
    {
        laserIndices.Add(pos); // adding a line to the castrate function 

        // We creat a ray and a raycast hit within the cast array function 
        Ray2D ray2d = new Ray2D(pos, dir); 
        RaycastHit2D hit = Physics2D.Raycast(ray2d.origin,ray2d.direction, 30, 1);

        if(hit.transform != null) // two conditions, one if the ray hits an object and one if it dosen't,  in the if statment we are going to cast an ray that is 30 units long 
        {
            CheckHit(hit, dir, laser); // add parameters   
        }
        else 
        {
            // in the else statment we 
            laserIndices.Add(ray2d.GetPoint(30));// Add a point 30 units along the ray to the laser indices list 
            UpdateLaser();
        }
    }

    void UpdateLaser()
    {
        int count = 0; // creating  a counter, starts at 0 
        laser.positionCount = laserIndices.Count; // i set the number of positions in the linerenderer equal to the number of points that we have in the laser indices list

        foreach (Vector2 idx in laserIndices) // we add each position from the laser indies list 
        {
            // to the corresponding linerenderer positions
            laser.SetPosition(count, idx);
            count++;
        }
    }

    
    void CheckHit(RaycastHit2D hitInfo, Vector2 direction, LineRenderer laser)
    {

        // we check whether or not  the hitinfo is colliding with an mirror or another object

        if (hitInfo.collider.gameObject.tag == "Mirror") // in the if statment we check wether or not the gameobject  that the ray collides with has a tag called Mirror
        {
            
            // if it does collide with a Mirror we get the reflected direction of the Beam 
            //we can do this by using the vector3 dot reflect function, this takes the direction of the ray and the normal of the surface that the ray hits
            Vector2 pos = hitInfo.point;
            Vector2 dir = Vector2.Reflect(direction, hitInfo.normal);

            CastRay(pos, dir, laser); // then it gives me a new direction that i can use to cast another ray using the cast ray function
        }
        if (hitInfo.collider.gameObject.tag == "Box") //If we hit a gameobject with the tag name Box
        {
            UnityEngine.Object.Destroy(hitInfo.collider.gameObject); // then we destroy it
        }
    }
}

    

