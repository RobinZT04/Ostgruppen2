using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongButton : MonoBehaviour
{
    // Variabler för varje dörrs mesh renderer och box collider -Henry
    [SerializeField]
    MeshRenderer rend;
    [SerializeField]
    BoxCollider dooors;

    [SerializeField]
    MeshRenderer rend2;
    [SerializeField]
    BoxCollider dooors2;

    [SerializeField]
    MeshRenderer rend3;
    [SerializeField]
    BoxCollider dooors3;

    [SerializeField]
    MeshRenderer rend4;
    [SerializeField]
    BoxCollider dooors4;

    // Variabel för testspelarens rigidbody -Henry
    public Rigidbody testPlayerReset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // När man kolliderar med triggern för fel knapp får varje dörr tillbaka sina mesh renderers och box colliders -Henry
        if (rend.enabled == false)
        {
            rend.enabled = true;
        }
        if (dooors.enabled == false)
        {
            dooors.enabled = true;
        }

        if (rend2.enabled == false)
        {
            rend2.enabled = true;
        }
        if (dooors2.enabled == false)
        {
            dooors2.enabled = true;
        }

        if (rend3.enabled == false)
        {
            rend3.enabled = true;
        }
        if (dooors3.enabled == false)
        {
            dooors3.enabled = true;
        }

        if (rend4.enabled == false)
        {
            rend4.enabled = true;
        }
        if (dooors4.enabled == false)
        {
            dooors4.enabled = true;
        }

        // När man kolliderar med triggern flyttas playern tillbaks till början -Henry
        testPlayerReset.transform.position = new Vector3(-10.57f, 0, -2.51f);
    }
}