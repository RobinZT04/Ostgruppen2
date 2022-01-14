using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawHealth : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) //on trigger enter
    { 
        if(other.transform.tag == "Sword") //rör den svärdet
        {
            Boss.Health -= 10; //förlorar bossen 10 health
        }
    }
}
