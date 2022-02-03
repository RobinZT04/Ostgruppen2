using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D player;
    Movement playerMovement;
    Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = player.gameObject.GetComponent<Movement>();
        playerAnim = player.GetComponentInChildren<Animator>();
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
        playerAnim.SetTrigger("Fall");
        playerMovement.enabled = false;
        //Start fall animation.
        yield return new WaitForSeconds(2);
        player.transform.position = new Vector2(-11.59f, -0.13218f);
        playerMovement.enabled = true;
    }
}