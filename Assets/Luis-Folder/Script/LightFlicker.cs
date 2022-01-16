using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float amount; // will be the amount of the light flicker

    public float speed; // will be the speed of the flicker 

    Light localLight; // this is a reference to the light component 
    float intensity; // This is the collective intensity of the light component 
    float offset; // This one will be an offset so all the flickers are different 


     void Start()
    {
        //will get a reference to the light component on the child object 
        localLight = GetComponentInChildren<Light>();

        // this will record the intensity and pick a random seed number to start 
        intensity = localLight.intensity;
        offset = Random.Range(0, 10000);

     }

     void Update()
    {
        // Will be using perlin noise, determine a random intensity amount 
        float amt = Mathf.PerlinNoise(Time.time * speed + offset, Time.time * speed + offset) * amount; // 
        localLight.intensity = intensity + amt;
    }

}
