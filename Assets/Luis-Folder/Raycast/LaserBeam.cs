using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


 // Made by José Luis SU20A
public class LaserBeam 
{
    Vector3 pos, dir;

   public GameObject laserObj;
    LineRenderer laser;
    List<Vector3> laserIndices = new List<Vector3>(); // make a list to store vector3's to store each point of the laser beam

    Dictionary<string, float> refractiveMaterials = new Dictionary<string, float>()
{
      {"Air", 1.0f}, // give it an idex value of one
      {"Glass", 1.5f } // give it an idex value of 1.5
    };
    public LaserBeam(Vector3 pos, Vector3 dir, Material material)
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

    void CastRay(Vector3 pos, Vector3 dir, LineRenderer laser) // we creat a new method called cast ray. The method i creat will have two vector3 parameters being the position and direction, also going to have a line renderer parameter being the laser
    {
        laserIndices.Add(pos); // adding a line to the castrate function 

        // We creat a ray and a raycast hit within the cast array function 
        Ray ray = new Ray(pos, dir); 
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 30, 1)) // two conditions, one if the ray hits an object and one if it dosen't,  in the if statment we are going to cast an ray that is 30 units long 
        {
            CheckHit(hit, dir, laser); // add parameters 
        }
        else 
        {
            // in the else statment we 
            laserIndices.Add(ray.GetPoint(30));// Add a point 3o units along the ray to the laser indices list 
            UpdateLaser();
        }
    }

    void UpdateLaser()
    {
        int count = 0; // creating  a counter, starts at 0 
        laser.positionCount = laserIndices.Count; // i set the number of positions in the linerenderer equal to the number of points that we have in the laser indices list

        foreach (Vector3 idx in laserIndices) // we add each position from the laser indies list 
        {
            // to the corresponding linerenderer positions
            laser.SetPosition(count, idx);
            count++;
        }
    }

    void CheckHit(RaycastHit hitInfo, Vector3 direction, LineRenderer laser)
    {
        // we check whether or not  the hitinfo is colliding with an mirror or another object

        if (hitInfo.collider.gameObject.tag == "Mirror") // in the if statment we check wether or not the gameobject  that the array collides with has a tag called Mirror
        {
            // if it does collide with a Mirror we get the reflected direction of the Beam 
//we can do this by using the vector3 dot reflect function, this takes the direction of the ray and the normal of the surface that the ray hits
            Vector3 pos = hitInfo.point;
            Vector3 dir = Vector3.Reflect(direction, hitInfo.normal);

            CastRay(pos, dir, laser); // then it gives me a new direction that i can use to cast another ray using the cast ray function
        }
        else if (hitInfo.collider.gameObject.tag == "Refract") // we check if the tag is named Refract
        {
            
            Vector3 pos = hitInfo.point;// we add hit point for the indices list
            laserIndices.Add(pos); // we add the position at the entrance to the glass, to the laserIndices list 


// we are going to go through each coordinate in the pos vector3 position which is above this text and going to alter each coordinate individually.
// we are going to start with the x, we're going to get the direction of the x vector in the direction vector3.
//Så i added the 0.0001f because if both of the x directions are zero then we're going to get an undefine number and we're probobly going to run into an error
// so i make it a really small number in the denominator just in case. Then i multiply it by 0.001f to make sure that it's as small as possible and still within the box collider, and add the x position back in there
// i will repeat it for y and z.
            Vector3 newPos1 = new Vector3(Mathf.Abs(direction.x) / (direction.x + 0.0001f) * 0.001f + pos.x, Mathf.Abs(direction.y) / (direction.y + 0.0001f) * 0.001f + pos.y, Mathf.Abs(direction.z) / (direction.z + 0.0001f) * 0.001f + pos.z); //
            float n1 = refractiveMaterials["Air"]; // initialize out value or the variables for solving the refraction problem 
            float n2 = refractiveMaterials["Glass"];

            Vector3 norm = hitInfo.normal;// the normal of the surface that the laser hits 
            Vector3 incident = direction; // incident direction which we got 

            Vector3 refractedVector = Refract(n1, n2, norm, incident);// Now i should be able to use the refracted method i made to get the first refreacted vector of the laser through the glass, New vector

            // This will be the point outside of the box collider 
            Ray ray1 = new Ray(newPos1, refractedVector);
            Vector3 newRayStartPos = ray1.GetPoint(1.5f); // Just going to note here that the variable 1.5f kommer att vara annorlunda baserad på storleken på objekten som du fersöker att träffa. 
            // Så i fårt fall så är det glasset och vi kommer att gå 1,5 enheter bort från startpunkten från den brutna vektorn, LMAO WHY DID I START WRITING ON SWEDISH (:

            Ray ray2 = new Ray(newRayStartPos, -refractedVector); // opposide direction of the scripts above this one
            RaycastHit hit2; // new raycast 

            if(Physics.Raycast(ray2, out hit2, 1.6f, 1)) // we check if ray hits any colliders         1.6f is how far the ray will cast.
            {
                laserIndices.Add(hit2.point); // if it does hit i add that hit point to the laserIndices 
            }

            UpdateLaser();

            // Final refracted vector 
            Vector3 refractedVector2 = Refract(n2, n1, -hit2.normal, refractedVector); // vector3 called refractedvector2 = refract we use n2 first since the initial material is glass and the exit material is air so we just swap the air and glass values
            //And the norm will be -hit2.normal cause the normal of the raycast in the oppisite direction is still in the oppisite direction so we will need to flip it back, the angle as the refractedvector. 

            CastRay(hit2.point, refractedVector2, laser); // now we can castRay with the new refrected vector using our castRay method 
        }
        else // if it does not hit a mirror
        {
            // add the hit point to the laserindices list and then update the laser 
            laserIndices.Add(hitInfo.point); 
            UpdateLaser();
        }
    }

    Vector3 Refract(float n1, float n2, Vector3 norm, Vector3 incident) // method called refract and it's going to return a vector3, it's going to take in floats,vector3 for the normal and a vector3 for the incident.
    {
        incident.Normalize(); // normalize the incident angel 
                              // calculate the refracted vector by taking snell's law but we apply it to vector math 

        Vector3 refractedVector = (n1 / n2 * Vector3.Cross(norm, Vector3.Cross(-norm, incident)) - norm * Mathf.Sqrt(1 - Vector3.Dot(Vector3.Cross(norm, incident) * (n1 / n2 * n1 / n2), Vector3.Cross(norm, incident)))).normalized; // My head hurts a lot, PLEASE HELP ME!!!!!!!!1 SOMEONE 
        return refractedVector;
    }
}
