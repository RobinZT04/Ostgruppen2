using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{ 
    public static float Health; //float health
    public Slider healthbar; //referens till healthbar
    public bool up; //bool up
    
    // Start is called before the first frame update
    void Start()
    {

        Health = 100; //health är 100
        healthbar.maxValue = 100; //maxvalue är 100
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = Health; //value är health
        if(Health <= 50) // om health är under 50
        {
            LeftPaw.speed = 3.5f; //sätt speed till 3.5f
        } else //annars
        {
            LeftPaw.speed = 2; //sätt speed till 2
        }
    }
}
