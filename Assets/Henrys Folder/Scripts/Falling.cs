using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D player;

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
        StartCoroutine(Fall());
    }

    IEnumerator Fall() 
    {
        //Start fall animation.
        yield return new WaitForSeconds(2);
        player.transform.position = new Vector2(-11.59f, -0.13218f);
    }
}
