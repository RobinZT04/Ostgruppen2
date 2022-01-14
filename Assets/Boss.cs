using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public static float Health;
    public Slider healthbar;
    public bool up;
    
    // Start is called before the first frame update
    void Start()
    {

        Health = 100;
        healthbar.maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = Health;
        if(Health <= 50)
        {
            LeftPaw.speed = 3.5f;
        } else
        {
            LeftPaw.speed = 2;
        }
    }
}
