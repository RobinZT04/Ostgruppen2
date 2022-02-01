using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform targetPlayer;
    public float speed;
    private void Update()
    {
        if (Vector2.Distance(transform.position, targetPlayer.position) <= 10) //om positionen är högre än tillåtna distansen  - Robin
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime); //rör transform mot player positionen  - Robin
        }
    }
}
