using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PHealthbar : MonoBehaviour
{
    public Slider healthbar; //En referens till min slider- Elanor
    public static float health; //Ean float som heter health- Elanor

    // Start is called before the first frame update
    void Start()
    {
        health = 10; //player har 10 health när spelets startas- Elanor
        healthbar.maxValue = 10; //Max health är 10 hp- Elanor 
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = health; //helathbars value är samma sak som health- Elanor

    }
}
