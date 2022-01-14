using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawHealth : MonoBehaviour
{
    public AudioSource Cathurtsource;
    public AudioClip Cathurt;
    private void OnTriggerEnter2D(Collider2D other) //on trigger enter
    { 
        if(other.transform.tag == "Sword") //rör den svärdet
        {
            if (!Cathurtsource.isPlaying)
            {
                Cathurtsource.PlayOneShot(Cathurt, 1);
            }
            Boss.Health -= 10; //förlorar bossen 10 health
        }
    }
}
