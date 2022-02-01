using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform targetPlayer;
    public float speed;
    public float walkingroute;
    public Vector3 punkt1;
    public Vector3 punkt2;
    public Vector3 punkt3;
    public Vector3 punkt4;
    public Vector3 punkt5;
    public Vector3 punkt6;
    public Vector3 punkt7;
    public Vector3 punkt8;
    public Vector3 punkt9;
    public Vector3 punkt10;

    public Vector3 nextpunkt;
    public bool following;

    private void Start()
    {
        walkingroute = 9;
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
            } 
            if(walkingroute == -1)
            {
                walkingroute = 9;
            }
           

            switch (walkingroute)
            {
                case 9:
                    transform.position = Vector2.MoveTowards(transform.position, punkt1, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkt1;
                    break;
                case 8:
                    transform.position = Vector2.MoveTowards(transform.position, punkt2, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkt2;
                    break;
                case 7:
                    transform.position = Vector2.MoveTowards(transform.position, punkt3, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkt3;
                    break;
                case 6:
                    transform.position = Vector2.MoveTowards(transform.position, punkt4, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkt4;
                    break;
                case 5:
                    transform.position = Vector2.MoveTowards(transform.position, punkt5, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkt5;
                    break;
                case 4:
                    transform.position = Vector2.MoveTowards(transform.position, punkt6, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkt6;
                    break;
                case 3:
                    transform.position = Vector2.MoveTowards(transform.position, punkt7, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkt7;
                    break;
                case 2:
                    transform.position = Vector2.MoveTowards(transform.position, punkt8, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkt8;
                    break;
                case 1:
                    transform.position = Vector2.MoveTowards(transform.position, punkt9, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkt9;
                    break;
                case 0:
                    transform.position = Vector2.MoveTowards(transform.position, punkt10, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
                    nextpunkt = punkt10;
                    break;
            }
        }
    }
}
