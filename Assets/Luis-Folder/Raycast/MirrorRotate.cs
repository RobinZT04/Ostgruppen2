using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorRotate : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sword")
        {
            transform.Rotate(0, 0, 90); //rotates The object 90 degrees
        }
    }
}
