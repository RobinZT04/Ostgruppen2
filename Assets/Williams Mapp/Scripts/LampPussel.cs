﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampPussel : MonoBehaviour
{
    public GameObject[] lampor;
    int tändaLampor;
    public AudioSource tändaSläckaLjud;
    public bool löst;
    public AudioSource lösaPusselLjud;
    public GameObject ost;
    //Kollar ifall alla lampor är tända -William
    public void ÄrPussletLöst()
    {
        foreach (GameObject item in lampor)
        {
            if (item.GetComponent<SpriteRenderer>().sprite.name == "LightPuzzleOn")
            {
                tändaLampor++;
            }
        }
        //Ifall alla lampor är tända så vinner man -William
        if (tändaLampor == lampor.Length)
        {
            lösaPusselLjud.Play();
            löst = true;
            ost.SetActive(true);
        }
        else
        {
            tändaLampor = 0;
        }
    }
}
