using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int health = 3; //Players hp är 10- Elanor 
    public int damage = 5; //En int som heter damage som då ska göra 5 damage- Elanor 
    public GameObject sword; //Ett gameobject som heter sword- Elanor 
    public GameObject swordup;
    public GameObject sworddown;

    public bool up;
    public bool right;
    public bool left;
    public bool down;

    // Start is called before the first frame update
    void Start()
    {
        sword.SetActive(false); //Sword ska inte vara aktiv när spelet startas (det syns alltså inte)- Elanor
        swordup.SetActive(false);
        sworddown.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            up = true;
            down = false;
            left = false;
            right = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            down = true;
            up = false;
            right = false;
            left = false;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
            up = false;
            right = false;
            down = false;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
            up = false;
            down = false;
            left = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (up)
            {
                swordup.SetActive(true);
                StartCoroutine(Cooldown());
            }
            if (down)
            {
                sworddown.SetActive(true);
                StartCoroutine(Cooldown());
            }
            if (right || left)
            {
                sword.SetActive(true);
                StartCoroutine(Cooldown());
            }
        }


        /*if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.A )|| Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.D)) //När man trycker space?- Elanor 
        {
            Debug.Log("attack"); //Konsolen skirver ut "attack"- Elanor
            sword.SetActive(true); //Sword blir aktiv och syns när man trycker space- Elanor
            StartCoroutine(Cooldown()); // En coroutin startas- Elanor 
        }

        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.W)) //Om man trycker ner D?
        {
            Debug.Log("attack"); //Konsolen skirver ut "attack"- Elanor
            swordup.SetActive(true); //Sword blir aktiv och syns när man trycker space- Elanor
            StartCoroutine(Cooldown()); // En coroutin startas- Elanor 
        }
*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Katt") //Om player colliderar med något som har tagen katt?- Elanor
        { 


        }
    } 
    IEnumerator Cooldown() //Min coroutin Cooldown- Elanor 
    {
        yield return new WaitForSeconds(0.5f); //Vänta 1 sekund- Elanor
        sword.SetActive(false); //Efter 1 sekund blir sword disable och syns inte- Elanor
        swordup.SetActive(false);
        sworddown.SetActive(false);
    }
}
