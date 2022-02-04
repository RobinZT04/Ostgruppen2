using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //WILLIAM OCH ROBIN har gjort det här :)
    public Transform targetPlayer;
    public float speed;
    public Vector3[] punkter;
    public int punktplats;

    public int maxroute;

    public Vector3 nextpunkt;
    public bool following;

    Rigidbody2D body;
    public Vector3 moveDirection;
    public bool punched;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        punktplats = 0;
        punched = false;
    }
    private void Update()
    {
        if(!punched)
        {
        if (Vector2.Distance(transform.position, targetPlayer.position) <= 5) //om positionen är högre än tillåtna distansen  - Robin
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
            following = true;
        } else
        {
            following = false;
        }

        if (!following)
        {
            transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
            nextpunkt = punkter[punktplats];

            if (transform.position == nextpunkt)
            {
                punktplats += 1;
            }
            if(punktplats == maxroute)
            {
                punktplats = 0;
            }
        }

        }
    }
    IEnumerator Stunned()
    {
        punched = true;
        moveDirection = body.transform.position - targetPlayer.transform.position;
        body.AddForce(moveDirection.normalized * 350f);
        yield return new WaitForSeconds(0.45f);
        body.velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(0.4f);
        punched = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Sword")
        {
            StartCoroutine(Stunned());
        }
    }
}
