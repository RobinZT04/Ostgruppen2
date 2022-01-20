using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Made by José Luis SU20A
public class MirrorRotate : MonoBehaviour
{
     void Start()
    {
        Debug.Log("Hello");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Mirror"))
        {
            Debug.Log("ROTATED MIRROR");
            other.gameObject.transform.Rotate(0, 0, 90); // so quaternions are basicaly 4 x's but unity has only 3 x's so to be able to use all the 4 x's we type Euler. X and Y have 0 and the z has 90 degress
        }
    }   
}

