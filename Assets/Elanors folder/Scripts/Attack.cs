using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int health = 3; //Players hp är 10- Elanor 
    public int damage = 5; //En int som heter damage som då ska göra 5 damage- Elanor 
    public GameObject sword; //Ett gameobject som heter sword- Elanor 
    // Start is called before the first frame update
    void Start()
    {
        sword.SetActive(false); //Sword ska inte vara aktiv när spelet startas (det syns alltså inte)- Elanor
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //När man trycker space?- Elanor 
        {
            Debug.Log("attack"); //Konsolen skirver ut "attack"- Elanor
            sword.SetActive(true); //Sword blir aktiv och syns när man trycker space- Elanor
            StartCoroutine(Cooldown()); // En coroutin startas- Elanor 
        }
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Katt") 
        { 


        }
    } 
    IEnumerator Cooldown() //Min coroutin Cooldown- Elanor 
    {
        yield return new WaitForSeconds(1); //Vänta 1 sekund- Elanor
        sword.SetActive(false); //Efter 1 sekund blir sword disable och syns inte- Elanor
    }
}
