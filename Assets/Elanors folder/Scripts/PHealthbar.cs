using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Kod skriven av Elanor 
public class PHealthbar : MonoBehaviour
{
    public Slider healthbar; //En referens till min slider- Elanor
    public static float health; //Ean float som heter health- Elanor
    public bool soundon; //En bool - Elanor
    

    public AudioSource mousedead; // Refrens till min audiosorce- Elanor 
    public AudioClip mousegone; //referens till aduioclip- Elanor


    // Start is called before the first frame update
    void Start()
    {
        health = 10; //player har 10 health när spelets startas- Elanor
        healthbar.maxValue = 10; //Max health är 10 hp- Elanor 
        soundon = false; //Soundon är false- Elanor 
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = health; //helathbars value är samma sak som health- Elanor
        
        if(health <= 0) //om health är mindre eller är 0?
        {
            Movement.död = true; //så ska speed bli 0- Elanor
            StartCoroutine(Respawn());
            //restart.SetActive(true); //Och restart ska aktiveras- Elanor 

            if (!soundon) //Om soundon inte spelas? -Elanor
            {
               
                mousedead.PlayOneShot(mousegone, 1); // Spela den 1 gång på volym 1- Elanor 
                soundon = true; //soundon är true- Elanor 
            }

        }

    }
    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2);
        Movement.död = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //laddar den nuvarande scenen igen- Elanor
    }
}
