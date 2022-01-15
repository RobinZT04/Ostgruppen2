using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{ 
    public static float Health; //float health  - Robin
    public Slider healthbar; //referens till healthbar  - Robin
    public bool up; //bool up  - Robin
    public GameObject paw1; //referens till paw1  - Robin
    public GameObject paw2; //referens till paw 2  - Robin
    public Animator cat; //cat animator referens  - Robin

    public AudioSource catsleepsource;
    public AudioClip catsleep;

    // Start is called before the first frame update
    void Start()
    {

        Health = 100; //health är 100  - Robin
        healthbar.maxValue = 100; //maxvalue är 100  - Robin 
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0) //om health är under 0  - Robin
        {
            paw1.SetActive(false); //stäng av paw 1  - Robin
            paw2.SetActive(false); //stäng av paw 2  - Robin
            cat.SetBool("Die", true); //playar animationen  - Robin
            catsleepsource.PlayOneShot(catsleep, 1);
        }
        healthbar.value = Health; //value är health  - Robin
        if (Health <= 50) // om health är under 50  - Robin
        {
            LeftPaw.speed = 3.5f; //sätt speed till 3.5f  - Robin
        }
        else //annars  - Robin
        {
            LeftPaw.speed = 2; //sätt speed till 2  - Robin
        }
    }
}
