using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //WILLIAM OCH ROBIN har gjort det här :)
    public Transform targetPlayer;
    public float speed;
    public int walkingroute;
    public Vector3[] punkter;
    public int punktplats;

    public Vector3 nextpunkt;
    public bool following;

    private void Start()
    {
        walkingroute = 9;
        punktplats = 0;
    }
    private void Update()
    {
        if (Vector2.Distance(transform.position, targetPlayer.position) <= 5) //om positionen är högre än tillåtna distansen  - Robin
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
            following = true;
        } else
        {
            following = false;
        }

        if(!following)
        {
            if (transform.position == nextpunkt)
            {
                walkingroute -= 1;
                punktplats += 1;
            } 
            if(walkingroute == -1)
            {
                walkingroute = 9;
                punktplats = 0;
            }

            switch (walkingroute)
            {
                case 9:
                    transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkter[punktplats];
                    break;
                case 8:
                    transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkter[punktplats];
                    break;
                case 7:
                    transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkter[punktplats];
                    break;
                case 6:
                    transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkter[punktplats];
                    break;
                case 5:
                    transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkter[punktplats];
                    break;
                case 4:
                    transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkter[punktplats];
                    break;
                case 3:
                    transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkter[punktplats];
                    break;
                case 2:
                    transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkter[punktplats];
                    break;
                case 1:
                    transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkter[punktplats];
                    break;
                case 0:
                    transform.position = Vector2.MoveTowards(transform.position, punkter[punktplats], speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkter[punktplats];
                    break;
            }
        }
    }
}
