using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    //Referenser för spelarens rigidbody, movement och animation -Henry
    [SerializeField]
    Rigidbody2D player;
    Movement playerMovement;
    Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        // Hämtar komponenterna Movement och Animator -Henry
        playerMovement = player.gameObject.GetComponent<Movement>();
        playerAnim = player.GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // När något kolliderar med triggern startar fall animationen -Henry
        StartCoroutine(Fall());
    }

    IEnumerator Fall() 
    {
        // När animationen spelas disableas movement scriptet och spelaren stannar -Henry
        playerAnim.SetTrigger("Fall");
        playerMovement.enabled = false;
        player.velocity = Vector3.zero;

        // Sedan väntar den i 1.33 sekunder... -Henry
        yield return new WaitForSeconds(1.33f);

        // ... och flyttar sedan spelaren till början, "resetar" sin rotation (både sig själv och sin child) 
        // och aktiverar movement scriptet igen -Henry
        player.transform.position = new Vector2(-11.59f, -0.13218f);
        player.transform.rotation = Quaternion.Euler(Vector3.zero);
        player.transform.GetChild(3).rotation = Quaternion.Euler(Vector3.zero);
        playerMovement.enabled = true;
    }
}