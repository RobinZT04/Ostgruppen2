using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code made by non other then José Luis SU20A
public class ShootLaser : MonoBehaviour
{
    public Material material; // creat a public material variable 
    LaserBeam beam; // creat a laserBeam variable 


    // Update is called once per frame
    void Update()
    {
        if (beam != null)
        {
            Destroy(beam.laserObj);
        }

        
        beam = new LaserBeam(gameObject.transform.position, gameObject.transform.right, material); // we creat a new laser beam every update 
    }
}
