using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OstScript : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Player")
        {
            OstbrickaScript.ostcounter += 1;
            Destroy(gameObject);
        }
    }
}
