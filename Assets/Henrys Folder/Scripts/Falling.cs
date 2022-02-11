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
        player.velocity = Vector3.zero;
        //Start fall animation.
        yield return new WaitForSeconds(1.33f);
        player.transform.position = new Vector2(-11.59f, -0.13218f);
        player.transform.rotation = Quaternion.Euler(Vector3.zero);
        player.transform.GetChild(3).rotation = Quaternion.Euler(Vector3.zero);
        playerMovement.enabled = true;
    }
}