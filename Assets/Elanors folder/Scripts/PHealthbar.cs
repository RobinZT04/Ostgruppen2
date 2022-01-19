﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PHealthbar : MonoBehaviour
{
    public Slider healthbar; //En referens till min slider- Elanor
    public static float health; //Ean float som heter health- Elanor
    public GameObject restart; //referens till gamgeobject restart- Elanor 
    

    public AudioSource mousedead; // Refrens till min audiosorce- Elanor 
    public AudioClip mousegone; //referens till aduioclip- Elanor


    // Start is called before the first frame update
    void Start()
    {
        health = 0; //player har 10 health när spelets startas- Elanor
        healthbar.maxValue = 10; //Max health är 10 hp- Elanor 
        restart.SetActive(false); //restart objectet är inaktiv när spelet börjar- Elanor 
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = health; //helathbars value är samma sak som health- Elanor
        
        if(health <= 10) //om health är mindre eller är 0?
        {
            Movement.speed = -0; //så ska speed bli 0- Elanor
            restart.SetActive(true); //Och restart ska aktiveras- Elanor 

            if (!mousedead.isPlaying) //Om audiosource inte spelas?
            {
                mousedead.PlayOneShot(mousegone, 1); // Spela den 1 gång på volym 1
            }

        }

    }

    public void Restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //laddar den nuvarande scenen igen- Elanor
    }

}
