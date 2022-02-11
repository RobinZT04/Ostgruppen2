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

    int maxroute;

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
        maxroute = punkter.Length - 1;
    }
    private void Update()
    {
        //Om den inte är slagen -William och Robin
        if(!punched)
        {
            if (Vector2.Distance(transform.position, targetPlayer.position) <= 5) //om positionen är högre än tillåtna distansen  - Robin och William
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime); //rör transform mot player positionen  - Robin och William
                if (transform.position.x >= targetPlayer.position.x)
                {
                    transform.eulerAngles = new Vector3(180, 0, 0);
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
                following = true;
            } else
            {
                following = false;
            }

            if (!following)
            {
                transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //Rör sig mot nästa punkt i arrayen  - Robin och William
                nextpunkt = punkter[punktplats];
                //När man når sin destination så uppdateras ens nästa punkt -William och Robin
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
    //Kastar fienden bakåt och stunnar den -William och Robin
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
    //Ifall man blir slagen av spelaren så kallas Stunned-funktionen -William och Robin
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.CompareTag("Sword"))
        {
            StartCoroutine(Stunned());
        }
    }
}
