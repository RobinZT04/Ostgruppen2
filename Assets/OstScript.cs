using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OstScript : MonoBehaviour
{
    public static bool KnappusselLöst;
    public static bool LamppusselLöst;
    public static bool LabyrintLöst;
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Ifall osten rör spelaren tar spelaren upp osten, och mängden ostar man har går upp med ett. -William
        if(other.transform.tag == "Player")
        {
            OstbrickaScript.ostcounter += 1;
            Destroy(gameObject);
            //Ändrar en bool som tillhör scenen spelaren befinner sig i när den tar upp osten och visar ifall spelaren har löst pusslet. -William
            if (SceneManager.GetActiveScene().name == "Knappussel")
            {
                KnappusselLöst = true;
            }
            else if (SceneManager.GetActiveScene().name == "Labyrint")
            {
                LabyrintLöst = true;
            }
            else if (SceneManager.GetActiveScene().name == "Lamppussel")
            {
                LamppusselLöst = true;
            }
        }
    }
}
