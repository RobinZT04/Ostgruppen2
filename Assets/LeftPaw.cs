using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaw : MonoBehaviour
{
    public Transform Paw; //kordinaterna till indicatorn
    public Transform targetPlayer; //transform player
    public static float speed; //float speed 
    public float distance; //float distans

    public static bool following; //following bool
    public static bool attackpaw; //attack bool

    public static bool Canattack; //attack bool 

    public Animator bonkanim; //bonk animation referens

    public void Start()
    {
        following = true; //following är true
        speed = 3; //speed 3
    }
    // Update is called once per frame
    void Update()
    {
        if (following) //if following
        {
            if (Vector2.Distance(transform.position, targetPlayer.position) >= distance) //om positionen är högre än tillåtna distansen
            {
                Paw.transform.position = new Vector2(transform.position.x, transform.position.y + 3); // paw positionen
                transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime); //rör transform mot player positionen
            }
        }
        if (Vector2.Distance(transform.position, targetPlayer.position) <= 0.3) //om positionen är högre än tillåtna distansen
        {
            following = false; //following är false
            StartCoroutine(Attacking()); //coroutine Attacking
        }
    }

    IEnumerator Attacking() //coroutine Attacking
    {
        bonkanim.SetBool("Bonk", true); //bonk animation true
        //Paw.transform.position = new Vector2(transform.position.x, transform.position.y - 0.45f);
        yield return new WaitForSeconds(1); //väntar i 2 sekunder
        bonkanim.SetBool("Bonk", false); //bonk animation false
        following = true; //following är true
    }

}
