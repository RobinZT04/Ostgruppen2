using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OstbrickaScript : MonoBehaviour
{
    public GameObject ost;
    public GameObject ost2;
    public GameObject ost3;
    public static float ostcounter;

    // Update is called once per frame
    void Update()
    {
        if (ostcounter == 1) //om ost är 1 - Robin
        {
            ost.SetActive(true);
            ost2.SetActive(false);
            ost3.SetActive(false);
        }
        if (ostcounter == 2) //om ost är 2 - Robin
        {
            ost.SetActive(true);
            ost2.SetActive(false);
            ost3.SetActive(false);
        }
        if (ostcounter == 3) //om ost är 3 - Robin
        {
            ost.SetActive(true);
            ost2.SetActive(false);
            ost3.SetActive(false);
        }
    }
}
