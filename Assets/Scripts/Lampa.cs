using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampa : MonoBehaviour
{
    MeshRenderer mesh;
    public Material tänt;
    public Material släckt;
    public LampPussel lampPussel;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }
    private void OnMouseDown()
    {
        //Kollar ifall man redan löst pusslet eller ej -William
        if (lampPussel.löst != true)
        {
            TändaSläcka();

            //Spelar lampljudet -William
            lampPussel.audioSource.Play();

            //Racycasts som tänder/släcker lamporna bredvid -William
            RaycastHit2D hitUp = Physics2D.Raycast(transform.position, Vector2.up);
            if (hitUp.collider != null)
            {
                Lampa hitUpLampa = hitUp.collider.GetComponent<Lampa>();
                hitUpLampa.TändaSläcka();
            }

            RaycastHit2D hitDown = Physics2D.Raycast(transform.position, Vector2.down);
            if (hitDown.collider != null)
            {
                Lampa hitDownLampa = hitDown.collider.GetComponent<Lampa>();
                hitDownLampa.TändaSläcka();
            }

            RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, Vector2.left);
            if (hitLeft.collider != null)
            {
                Lampa hitLeftLampa = hitLeft.collider.GetComponent<Lampa>();
                hitLeftLampa.TändaSläcka();
            }

            RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.right);
            if (hitRight.collider != null)
            {
                Lampa hitRightLampa = hitRight.collider.GetComponent<Lampa>();
                hitRightLampa.TändaSläcka();
            }

            lampPussel.ÄrPussletLöst();
        }
        
    }
    //Byter materialet till antingen släckt eller tänt beroende på vad den nuvarande är -William
    public void TändaSläcka()
    {
        if (mesh.material.name == tänt.name + " (Instance)")
        {
            mesh.material = släckt;
        }
        else
        {
            mesh.material = tänt;
        }
    }
}
