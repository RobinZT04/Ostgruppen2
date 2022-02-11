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
    public Tilemap markTilemap;
    public TileBase markTile;
    public TileBase sidoväggTile;
    public GameObject spegelpusselDörr; //referens till spegeldörren
    public GameObject knappusselDörr; //referens till kanppusseldörren
    public GameObject lamppusselDörr; //referen still lampusseldörr
    void Start()
    {
        //Ifall man tagit upp osten så fylls osthjulet upp med det, och täcker igen hålet
        //till pusslet -William
        if (OstScript.KnappusselLöst) 
        {
            ost3.SetActive(true);
            markTilemap.SetTile(new Vector3Int(-22, 11, 0), markTile);
            knappusselDörr.SetActive(false);
        }
        if (OstScript.SpegelpusselLöst)
        {
            ost2.SetActive(true);
            markTilemap.SetTile(new Vector3Int(27, -13, 0), markTile);
            spegelpusselDörr.SetActive(false);
        }
        if (OstScript.LamppusselLöst)
        {
            ost.SetActive(true);
            markTilemap.SetTile(new Vector3Int(26, -1, 0), markTile);
            lamppusselDörr.SetActive(false);
        }
        if(ostcounter >= 3)
        {
            portTilemap.SwapTile(sidoväggTile, markTile);
            portTilemap.GetComponent<TilemapCollider2D>().enabled = false;
        }
    }
}
