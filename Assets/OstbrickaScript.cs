using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OstbrickaScript : MonoBehaviour
{
    public GameObject ost; //referens till ost1 - Robin
    public GameObject ost2; //referens till ost2 - Robin
    public GameObject ost3; //referens till ost3 - Robin
    public static float ostcounter; //float till ostcountern
    public Tilemap portTilemap;
    public GameObject spegelpusselDörr; //referens till spegeldörren
    public GameObject knappusselDörr; //referens till kanppusseldörren
    public GameObject lamppusselDörr; //referen still lampusseldörr
    void Start()
    {
        //Ifall man tagit upp osten så fylls osthjulet upp med det, och hålet till pusslet
        //slutar fungera. -William
        if (OstScript.KnappusselLöst)
        {
            ost3.SetActive(true);
            knappusselDörr.SetActive(false);
        }
        if (OstScript.LabyrintLöst)
        {
            ost2.SetActive(true);
            spegelpusselDörr.SetActive(false);
        }
        if (OstScript.LamppusselLöst)
        {
            ost.SetActive(true);
            lamppusselDörr.SetActive(false);
        }
        //Om man  har fått alla tre ostbitar så öppnas porten till bossrummet. -William
        if (ostcounter >= 3)
        {
            portTilemap.GetComponent<TilemapRenderer>().enabled = false;
            portTilemap.GetComponent<TilemapCollider2D>().enabled = false;
        }
    }
}
