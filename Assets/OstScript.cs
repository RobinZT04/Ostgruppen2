using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OstScript : MonoBehaviour
{
    public static bool KnappusselLöst;
    public static bool SpegelpusselLöst;
    public static bool LamppusselLöst;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Player")
        {
            OstbrickaScript.ostcounter += 1;
            Destroy(gameObject);
            if (SceneManager.GetActiveScene().name == "Knappussel")
            {
                KnappusselLöst = true;
            }
            else if (SceneManager.GetActiveScene().name == "Spegelpussel")
            {
                SpegelpusselLöst = true;
            }
            else if (SceneManager.GetActiveScene().name == "Lamppussel")
            {
                LamppusselLöst = true;
            }
        }
    }
}
