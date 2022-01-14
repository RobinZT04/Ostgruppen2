using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaw : MonoBehaviour
{
    public Transform Paw; //kordinaterna till indicatorn  - Robin
    public Transform targetPlayer; //transform player  - Robin
    public static float speed; //float speed   - Robin 
    public float distance; //float distans  - Robin

    public static bool following; //following bool  - Robin
    public static bool attackpaw; //attack bool  - Robin

    public static bool Canattack; //attack bool   - Robin

    public Animator bonkanim; //bonk animation referens  - Robin

    public AudioClip bonk; //referens till audioclip bonk  - Robin
    public AudioSource bonksource; //referens till bonk audio source  - Robin
    public void Start()
    {
        following = true; //following är true  - Robin
        speed = 3; //speed 3  - Robin
    } 
    // Update is called once per frame  - Robin
    void Update()
    {
        if (following) //if following  - Robin
        {
            if (Vector2.Distance(transform.position, targetPlayer.position) >= distance) //om positionen är högre än tillåtna distansen  - Robin
            {
                Paw.transform.position = new Vector2(transform.position.x, transform.position.y + 3); // paw positionen  - Robin
                transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
            }
        }
        if (Vector2.Distance(transform.position, targetPlayer.position) <= 0.3) //om positionen är högre än tillåtna distansen  - Robin
        {
            following = false; //following är false  - Robin
            StartCoroutine(Attacking()); //coroutine Attacking  - Robin
        }
    }

    IEnumerator Attacking() //coroutine Attacking  - Robin
    {
        bonkanim.SetBool("Bonk", true); //bonk animation true  - Robin
        //Paw.transform.position = new Vector2(transform.position.x, transform.position.y - 0.45f);  - Robin
        yield return new WaitForSeconds(0.4f); //väntar i 2 sekunder  - Robin
        if (!bonksource.isPlaying) //om ljudet inte spelas  - Robin
        {
            bonksource.PlayOneShot(bonk, 1); //play one shot cat bonk  - Robin
        }
        yield return new WaitForSeconds(0.6f); //väntar i 2 sekunder  - Robin
        bonkanim.SetBool("Bonk", false); //bonk animation false  - Robin
        following = true; //following är true  - Robin
    }

}
