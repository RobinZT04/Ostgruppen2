using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject sword; //Ett gameobject som heter sword- Elanor 
    public GameObject swordup; //En referens till ett gameobject som jag har döpt swordup- Elanor 
    public GameObject sworddown; //En referens till ett gameobject som jag har döpt swordup- Elanor 

    public bool up; //En bool som heter up- Elanor
    public bool right; //En bool som heter right- Elanor
    public bool left; //En bool som heter left- Elanor
    public bool down; //En bool som heter down- Elanor

    // Start is called before the first frame update
    void Start()
    {
        sword.SetActive(false); //Sword ska inte vara aktiv när spelet startas (det syns alltså inte)- Elanor
        swordup.SetActive(false); //Swordup ska inte vara aktiv när spelet startas (det syns alltså inte)- Elanor
        sworddown.SetActive(false); //Sworddown ska inte vara aktiv när spelet startas (det syns alltså inte)- Elanor
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) //Om man håller ner W?- Elanor
        {
            up = true; // Up blir true- Elanor 
            down = false; // down blir false- Elanor 
            left = false; // left blir false- Elanor 
            right = false; // right blir false- Elanor 
        }
        if (Input.GetKeyDown(KeyCode.S)) //Om man håller ner S?- Elanor
        {
            down = true; // down blir true- Elanor 
            up = false; // up blir false- Elanor 
            right = false; // right blir false- Elanor 
            left = false; // left blir false- Elanor 
        }
        if (Input.GetKeyDown(KeyCode.A)) //Om man håller ner A? - Elanor
        {
            left = true; //left blir true- Elanor 
            up = false; // up blir false- Elanor 
            right = false; // rigt blir false- Elanor 
            down = false; // down blir false- Elanor 
        }
        if (Input.GetKeyDown(KeyCode.D)) //Om man håller ner D?- Elanor
        {
            right = true; // right blir true- Elanor 
            up = false; // up blir false- Elanor 
            down = false; // down blir false- Elanor 
            left = false; // left blir false- Elanor 
        }

        if (Input.GetKeyDown(KeyCode.Space)) //Om man trycket på space? - Elanor
        {
            if (up) // och är vänd mot up (W)?- Elanor
            {
                swordup.SetActive(true); //så kommer swordup bli true- Elanor 
                StartCoroutine(Cooldown()); //callar funkionen- Elanor
            }
            if (down) // är vänd mot down (S)?- Elanor
            {
                sworddown.SetActive(true); //så kommer sworddown bli true- Elanor 
                StartCoroutine(Cooldown()); //callar funkionen- Elanor
            }
            if (right || left) //Om spelaren är left eller right (A eller D)?- Elanor 
            {
                sword.SetActive(true); //så kommer sword bli true- Elanor 
                StartCoroutine(Cooldown()); //callar funkionen- Elanor
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Paw") //Om player colliderar med något som har tagen Paw?- Elanor
        {
            PHealthbar.health -= 2; //Så kommer players healths sänkas med 2- Elanor

        }
    } 
    IEnumerator Cooldown() //Min coroutin Cooldown- Elanor 
    {
        yield return new WaitForSeconds(0.5f); //Vänta 1 sekund- Elanor
        sword.SetActive(false); //Efter 1 sekund blir sword disable och syns inte- Elanor
        swordup.SetActive(false); //Efter 1 sekund blir swordup disable och syns inte- Elanor
        sworddown.SetActive(false); //Efter 1 sekund blir sworddown disable och syns inte- Elanor
    }
    
}
