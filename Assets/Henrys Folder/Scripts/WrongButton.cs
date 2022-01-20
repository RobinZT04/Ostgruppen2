using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongButton : MonoBehaviour
{
    // Variabler för varje dörrs sprite renderer och box collider -Henry
    [SerializeField]
    SpriteRenderer bridge;
    [SerializeField]
    BoxCollider2D dooors;

    [SerializeField]
    SpriteRenderer bridge2;
    [SerializeField]
    BoxCollider2D dooors2;

    [SerializeField]
    SpriteRenderer bridge3;
    [SerializeField]
    BoxCollider2D dooors3;

    [SerializeField]
    SpriteRenderer bridge4;
    [SerializeField]
    BoxCollider2D dooors4;

    // Variabel för testspelarens rigidbody -Henry
    public Rigidbody2D testPlayerReset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // När man kolliderar med triggern för fel knapp försvinner alla "broar" och "dooors" (osynliga väggar) får sin box collider -Henry
        if (bridge.enabled == true)
        {
            bridge.enabled = false;
        }
        if (dooors.enabled == false)
        {
            dooors.enabled = true;
        }

        if (bridge2.enabled == true)
        {
            bridge2.enabled = false;
        }
        if (dooors2.enabled == false)
        {
            dooors2.enabled = true;
        }

        if (bridge3.enabled == true)
        {
            bridge3.enabled = false;
        }
        if (dooors3.enabled == false)
        {
            dooors3.enabled = true;
        }

        if (bridge4.enabled == true)
        {
            bridge4.enabled = false;
        }
        if (dooors4.enabled == false)
        {
            dooors4.enabled = true;
        }

        // När man kolliderar med triggern flyttas playern tillbaks till början -Henry
        testPlayerReset.transform.position = new Vector3(-11.5f, 0, -0.01f);
    }
}