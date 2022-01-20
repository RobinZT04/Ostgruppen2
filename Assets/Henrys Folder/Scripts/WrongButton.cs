using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongButton : MonoBehaviour
{
    // Variabler för varje dörrs mesh renderer och box collider -Henry
    [SerializeField]
    MeshRenderer bridge;
    [SerializeField]
    BoxCollider2D dooors;

    [SerializeField]
    MeshRenderer bridge2;
    [SerializeField]
    BoxCollider2D dooors2;

    [SerializeField]
    MeshRenderer bridge3;
    [SerializeField]
    BoxCollider2D dooors3;

    [SerializeField]
    MeshRenderer bridge4;
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
        // När man kolliderar med triggern för fel knapp får varje dörr tillbaka sina mesh renderers och box colliders -Henry
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
        testPlayerReset.transform.position = new Vector3(-10.57f, 0, -0.01f);
    }
}