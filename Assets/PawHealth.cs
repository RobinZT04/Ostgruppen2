using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawHealth : MonoBehaviour
{
    public AudioSource Cathurtsource; //referens till audiosouce katt - Robin
    public AudioClip Cathurt; //kattens skado ljud klipp - Robin
    private void OnTriggerEnter2D(Collider2D other) //on trigger enter  - Robin
    { 
        if(other.transform.tag == "Sword") //rör den svärdet  - Robin
        {
            if (!Cathurtsource.isPlaying) //spelas kattljudet  - Robin
            {
                Cathurtsource.PlayOneShot(Cathurt, 1); //spela ljudet en gång  - Robin 
            }
            Boss.Health -= 10; //förlorar bossen 10 health  - Robin
        }
    }
}
