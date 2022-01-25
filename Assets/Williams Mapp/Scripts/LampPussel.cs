using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LampPussel : MonoBehaviour
{
    public GameObject[] lampor;
    int tändaLampor;
    public AudioSource tändaSläckaLjud;
    public bool löst;
    public AudioSource lösaPusselLjud;
    public GameObject ost;
    public Tilemap tilemap;
    public TileBase tileA;
    public TileBase tileB;
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
            tilemap.SwapTile(tileA, tileB);
            tilemap.GetComponent<TilemapCollider2D>().enabled = false;
        }
        else
        {
            tändaLampor = 0;
        }
    }
}
