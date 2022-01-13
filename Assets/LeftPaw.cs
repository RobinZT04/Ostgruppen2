using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaw : MonoBehaviour
{
    public Transform Paw; //kordinaterna till indicatorn
    public Transform targetPlayer;
    public float speed;
    public float distance;

    public static bool following;
    public static bool attackpaw;

    public static bool Canattack;

    public Animator bonkanim;

    public void Start()
    {
        following = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (following) //if following
        {
            if (Vector2.Distance(transform.position, targetPlayer.position) >= distance) //om positionen är högre än tillåtna distansen
            {
                Paw.transform.position = new Vector2(transform.position.x, transform.position.y + 3);
                transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime); //rör transform mot player positionen
            }
        }
        if (Vector2.Distance(transform.position, targetPlayer.position) <= 0.3) //om positionen är högre än tillåtna distansen
        {
            following = false;
            StartCoroutine(Attacking());
        }
    }

    IEnumerator Attacking() //coroutine Attacking
    {
        bonkanim.SetBool("Bonk", true);
        //Paw.transform.position = new Vector2(transform.position.x, transform.position.y - 0.45f);
        yield return new WaitForSeconds(2); //väntar i 2 sekunder
        bonkanim.SetBool("Bonk", false);
        following = true;
    }

}
