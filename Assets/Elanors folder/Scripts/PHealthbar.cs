using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PHealthbar : MonoBehaviour
{
    public Slider healthbar;
    public float health;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        healthbar.maxValue = 10;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = health;

    }
}
