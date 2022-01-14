﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LampPussel : MonoBehaviour
{
    public GameObject[] lampor;
    int tändaLampor;
    public AudioSource audioSource;
    public bool löst;
    //Kollar ifall alla lampor är tända -William
    public void ÄrPussletLöst()
    {
        foreach (GameObject item in lampor)
        {
            if (item.GetComponent<MeshRenderer>().material.name == "TäntMaterial (Instance)")
            {
                tändaLampor++;
            }
        }
        //Ifall alla lampor är tända så vinner man -William
        if (tändaLampor == lampor.Length)
        {
            print("Victory!");
            löst = true;
        }
        else
        {
            tändaLampor = 0;
        }
    }
}
